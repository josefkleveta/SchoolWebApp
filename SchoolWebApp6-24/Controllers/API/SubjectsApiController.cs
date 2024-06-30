using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.DTO;
using SchoolProject.Services;

namespace SchoolProject.Controllers.API {
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsApiController : ControllerBase {
        private SubjectService _subjectService;

        public SubjectsApiController(SubjectService subjectService) {
            _subjectService = subjectService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<SubjectDTO>> Index() {
           var allSubjects =  _subjectService.GetSubjects();
            return Ok(allSubjects);
        }

    }
}
