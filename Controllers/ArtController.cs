using artistapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace artistapi.Controllers{
  [ApiController]
  [Route("api/[controller]")]
  public class ArtController: ControllerBase{
    private readonly ArtService _as;
    public ArtController(ArtService ats){
      _as = ats;
    }
  }
}