package tn.esprit.examen.entities;
import jakarta.persistence.*;
import lombok.*;
import java.io.Serializable;
import java.util.Set;

@Entity
@Getter
@Setter
@NoArgsConstructor
@AllArgsConstructor
public class Portefeuille implements Serializable{
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer idPortefeuille;
    @Column(unique = true)
    private Integer reference;
    private Float solde;

    @OneToMany(cascade = CascadeType.ALL, mappedBy="portefeuille")
    private Set<Ordre> Ordres;

    @OneToMany(cascade = CascadeType.ALL, mappedBy="portefeuille")
    private Set<ElementPortefeuille> ElementPortefeuilles;

}
