package tn.esprit.examen.entities;
import jakarta.persistence.*;
import lombok.*;
import java.io.Serializable;
import java.time.LocalDate;

@Entity
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class Ordre implements Serializable{
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idOrdre;
    private Integer volume;
    private LocalDate dateCreaion;
    private LocalDate dateExecution;
    private float montant;
    @Enumerated(EnumType.STRING)
    private Statut statut;
    @Enumerated(EnumType.STRING)
    private TypeOrdre typeOrdre;

    @ManyToOne
    Portefeuille portefeuille;

    @ManyToOne
    Action action;
}
