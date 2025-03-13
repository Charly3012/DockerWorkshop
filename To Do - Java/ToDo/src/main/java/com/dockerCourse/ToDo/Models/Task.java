package com.dockerCourse.ToDo.Models;

import lombok.*;

import java.util.Date;
@Data
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class Task {
    public long idTask;
    public String name;
    public String description;
    public Date date;
}
