using Microsoft.AspNetCore.Mvc;
using TaskPulse.Api.Models;

namespace TaskPulse.Api.Controllers;

[ApiController]
public class TasksController
{
    public List<TaskItem> TaskItems { get; set; } = new();

}