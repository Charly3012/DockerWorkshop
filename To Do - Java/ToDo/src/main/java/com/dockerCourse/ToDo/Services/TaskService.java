package com.dockerCourse.ToDo.Services;

import com.dockerCourse.ToDo.Models.InsertTaskDTO;
import com.dockerCourse.ToDo.Models.Task;
import lombok.Getter;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.Date;
import java.util.List;

@Service
public class TaskService {
    @Getter
    private List<Task> taskList = new ArrayList<>();
    private long idCounter = 1;

    public TaskService() {
        taskList.add(new Task(idCounter++, "Aprender Docker", "Estudiar contenedores", new Date()));
        taskList.add(new Task(idCounter++, "¡DELINQUIIIIIR!", "Cometer algún crimen de odio en contra de la sociedad", new Date()));
        taskList.add(new Task(idCounter++, "Configurar API", "Crear endpoints en Spring Boot", new Date()));
        taskList.add(new Task(idCounter++, "Ejecutar API", "Levantar servidor con Spring Boot", new Date()));
        taskList.add(new Task(idCounter++, "Comprar criptos", "Ola, ya no se que poner en la descripción", new Date()));
    }

    public Task insertTask(InsertTaskDTO taskDTO) {
        Task newTask = new Task(idCounter++, taskDTO.getName(), taskDTO.getDescription(), new Date());
        taskList.add(newTask);
        return newTask;
    }

    public boolean deleteTask(long taskId) {
        return taskList.removeIf(task -> task.getIdTask() == taskId);
    }


}
