using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using models.DTO.ExamDTO;
using models.Model;

namespace lms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ExamController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExam(Guid id)
        {
            IGenericRepository<Exam> examRepository = _unitOfWork.Repository<Exam>();
            Exam exam = await examRepository.GetByIdAsync(id, include: new string[] { "Questions", "Questions.QuestionChoices" });
            ViewExamDTO viewExam = _mapper.Map<ViewExamDTO>(exam);
            return Ok(viewExam);
        }

        [HttpPost("{id}/questions")]
        public async Task<IActionResult> AddQuestions(Guid id, [FromBody] List<AddQuestionDTO> questions)
        {
            IGenericRepository<Question> questionRepository = _unitOfWork.Repository<Question>();
            foreach (var question in questions)
            {
                Question q = _mapper.Map<Question>(question);
                q.ExamId = id;
                await questionRepository.AddAsync(q);
                foreach (var choice in question.Choices)
                {
                    QuestionChoices qc = _mapper.Map<QuestionChoices>(choice);
                    qc.QuestionId = q.Id;
                    await _unitOfWork.Repository<QuestionChoices>().AddAsync(qc);
                }
            }
            await _unitOfWork.CommitAsync();
            return Ok();
        }
    }

    
}
