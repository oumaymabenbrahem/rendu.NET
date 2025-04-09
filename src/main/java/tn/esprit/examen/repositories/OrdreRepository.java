package tn.esprit.examen.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import tn.esprit.examen.entities.Ordre;
@Repository
public interface OrdreRepository extends JpaRepository<Ordre,Integer> {
}
