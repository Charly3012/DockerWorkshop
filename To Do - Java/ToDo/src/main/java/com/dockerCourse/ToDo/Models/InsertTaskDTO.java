package com.dockerCourse.ToDo.Models;

import lombok.*;

import java.util.Date;
@Data
@Builder
@Setter
@Getter
@NoArgsConstructor
@AllArgsConstructor
public class InsertTaskDTO {
    public String name;
    public String description;
}
