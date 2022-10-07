using AutoMapper;
using HcmMember.Dto;
using HcmMember.Modals;
using HcmMember.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace HcmMember.Controllers
{
    [ApiController]
    [Route("HealthCare")]
    public class MemberAndPhysicianController:ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMemberAndPhysician Repo;
        public MemberAndPhysicianController(IMapper mapper, IMemberAndPhysician Repo)
        {
            this.mapper = mapper;
            this.Repo = Repo;
        }

        [HttpGet]
        [Route("Physicians")]
        public ActionResult<List<PhysicianDto>> GetPhysicianList()
        {
            var physicians = Repo.GetPhysicians();
            if (physicians.Count == 0)
                return NotFound("No Physicians in database");
            return Ok(mapper.Map<List<PhysicianDto>>(physicians));
        }

        [HttpGet]
        [Route("GetMembers")]
        public ActionResult<List<MemberSearchDto>> GetMembersList()
        {
            List<Member> members = Repo.GetMembers(); 
            if(members.Count == 0)
                return NotFound("No members are there in database");
            List<MemberSearchDto> memberSearchDto = new List<MemberSearchDto>();
            memberSearchDto = mapper.Map<List<MemberSearchDto>>(members);
            return Ok(memberSearchDto);
        }

        [HttpPost]
        [Route("AddMember")]
        public ActionResult CreateMember(MemberDto memberDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            Member member = new Member();
            Random random = new Random();
            member = mapper.Map<Member>(memberDto);
            member.PhysicianId = random.Next(1,9);
            member.CreationDate = DateTime.Now;
            member.LastModificationDate = DateTime.Now;

            Repo.AddMember(member);

            return Ok();
        }
    }
}
