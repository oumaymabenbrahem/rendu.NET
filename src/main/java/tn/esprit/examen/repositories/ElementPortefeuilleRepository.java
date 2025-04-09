package tn.esprit.examen.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import tn.esprit.examen.entities.ElementPortefeuille;

@Repository
public interface ElementPortefeuilleRepository extends JpaRepository<ElementPortefeuille,Integer> {
}
