package com.dockerCourse.ToDo.Controllers;

import com.dockerCourse.ToDo.Models.HolaMundo;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/api/hello")
public class HolaMundoController {

    @GetMapping("world")
    public HolaMundo saludar() {
        HolaMundo holaMundo = new HolaMundo();
        holaMundo.setMessage("Este es un saludo desde la API, todo funcionando correctamente");
        return holaMundo;
    }

}


