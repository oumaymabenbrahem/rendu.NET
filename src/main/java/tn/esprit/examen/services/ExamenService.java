package tn.esprit.examen.services;

import jakarta.transaction.Transactional;
import lombok.AllArgsConstructor;
import lombok.extern.slf4j.Slf4j;
import org.springframework.stereotype.Service;
import tn.esprit.examen.entities.Action;
import tn.esprit.examen.entities.Ordre;
import tn.esprit.examen.entities.Portefeuille;
import tn.esprit.examen.repositories.ActionRepository;
import tn.esprit.examen.repositories.OrdreRepository;
import tn.esprit.examen.repositories.PortefeuilleRepository;

import java.util.List;
import java.util.Set;

@Service
@AllArgsConstructor
@Slf4j
public class ExamenService implements IExamenService{


    ActionRepository actionRepository;
    PortefeuilleRepository portefeuilleRepository;
    OrdreRepository ordreRepository;







   public List<Action>addActions(List<Action> listeActions){
       return actionRepository.saveAll(listeActions);

   }

    public Portefeuille addPortefeuilleWIthElements(Portefeuille portefeuille){
       portefeuille.getElementPortefeuilles().forEach(elementPortefeuille -> {elementPortefeuille.setPortefeuille(portefeuille);});
        return portefeuilleRepository.save(portefeuille);
    }

//    @Transactional
//    public FamilleActe ajouterFamilleActeEtActeAssocie(FamilleActe facte) {
//        // Sauvegarder d'abord la FamilleActe
//        FamilleActe f = familleActeRepository.save(facte);
//
//        // Parcourir les actes associés et les lier à la FamilleActe
//        Set<Acte> actes = f.getActes();
//        actes.forEach(acte -> {
//            // Lier chaque acte à la famille d'actes
//            acte.setFamilleActe(f);
//            // Sauvegarder chaque acte associé
//            acteRepository.save(acte);
//        });
//
//        // Retourner l'objet FamilleActe mis à jour avec ses actes
//        return f;
//    }




//    @Override
//    public void affecterUtilisateurClasse(Integer idUtilisateur, Integer idClasse) {
//        Classe c = classeRepository.findById(idClasse).get();
//        Utilisateur u = utilisateurReposiory.findById(idUtilisateur).get();
//        u.setClasse(c);
//        utilisateurReposiory.save(u);
//
//    }

//    @Override
//    public CoursClassroom ajouterCoursClassroom (CoursClassroom cc, Integer codeClasse) {
//        Classe classe= classeRepository.findById(codeClasse).get();
//        cc.setClasse(classe);
//        coursClassroumReposiory.save(cc);
//        return cc;
//    }

    @Override
    public Ordre addOrdreAndAffectToAcionAndPortefeuille(Ordre ordre, String symbole, Integer reference){
        Portefeuille pr = portefeuilleRepository.findById(reference).get();
        ordre.setPortefeuille(pr);
        ordreRepository.save(ordre);
        return ordre;

}


}
