namespace knightApi.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class KnightsController : ControllerBase
    {
        private readonly KnightsService _ks;

        public KnightsController(KnightsService ks)
        {
            _ks = ks;
        }
        
        //Get All
        [HttpGet]
         public ActionResult<IEnumerable<knight>> Get()
    {
      try
      {
        IEnumerable<knight> knights = _knightsService.Get();
        return Ok(knights);
      }
      catch (Exception err)
      {
        return BadRequest(err.Message);
      }
    }
    }
}