package tn.esprit.examen.entities;
import jakarta.persistence.*;
import lombok.*;
import java.io.Serializable;
import java.time.LocalDate;
import java.util.Set;

@Entity
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class Action implements Serializable{
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer  idAcion; // Clé primaire
    private Float prixAchatActuel;
    private Float prixVenteActuel;
    private Integer  volume;
    private LocalDate dateEmission;
@Column(unique = true)
    private String symbole;

    @OneToMany(cascade = CascadeType.ALL, mappedBy="action")
    private Set<Ordre> Ordres;
}
