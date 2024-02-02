using Microsoft.AspNetCore.Mvc;
using NetTrainingJan.Services;

// MyController.cs

[ApiController]
[Route("api/[controller]")]
public class EmpController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmpController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public IActionResult GetOutput()
    {
        var output = _employeeService.GetOutput();
        return Ok(output);
    }
}
