package tn.esprit.examen.entities;

import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.*;
import lombok.*;
import java.io.Serializable;

@Entity
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class ElementPortefeuille implements Serializable{
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idElement;
    private String symbole;
    private Integer nombreActions;
    private Float prixAchat;

    @ManyToOne
    Portefeuille portefeuille;

}
