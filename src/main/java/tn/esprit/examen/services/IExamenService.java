package tn.esprit.examen.services;

import tn.esprit.examen.entities.Action;
import tn.esprit.examen.entities.Ordre;
import tn.esprit.examen.entities.Portefeuille;

import java.util.List;

public interface IExamenService {


    List<Action>addActions(List<Action> listeActions);
    Portefeuille addPortefeuilleWIthElements(Portefeuille portefeuille);
    Ordre addOrdreAndAffectToAcionAndPortefeuille(Ordre ordre, String symbole, Integer reference);

}
