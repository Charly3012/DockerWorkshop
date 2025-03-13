package com.dockerCourse.ToDo.Controllers;

import com.dockerCourse.ToDo.Models.InsertTaskDTO;
import com.dockerCourse.ToDo.Models.Task;
import com.dockerCourse.ToDo.Services.TaskService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/api/tasks")
public class TaskController {

    @Autowired
    private final TaskService taskService;

    public TaskController(TaskService taskService) {
        this.taskService = taskService;
    }

    @GetMapping("getAll")
    public List<Task> getAllTasks() {
        return taskService.getTaskList();
    }

    @PostMapping("insert")
    public Task createTask(@RequestBody InsertTaskDTO taskDTO) {
        return taskService.insertTask(taskDTO);
    }

    @DeleteMapping("/{taskId}")
    public boolean deleteTask(@PathVariable long taskId) {
        return taskService.deleteTask(taskId);
    }
}
