package tn.esprit.examen.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
import tn.esprit.examen.entities.Action;

@Repository
public interface ActionRepository extends JpaRepository<Action,Integer> {
    Action findActionBysymbole(String symbole);
}
