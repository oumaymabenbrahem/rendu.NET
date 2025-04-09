package tn.esprit.examen.controllers;


import lombok.AllArgsConstructor;
import org.springframework.web.bind.annotation.*;
import tn.esprit.examen.entities.Action;
import tn.esprit.examen.entities.Ordre;
import tn.esprit.examen.entities.Portefeuille;
import tn.esprit.examen.services.IExamenService;

import java.util.List;

@RestController
@AllArgsConstructor
@RequestMapping("/projet")
public class ExamenController {

    IExamenService examenService;



    @PostMapping("/add-actions")
    @ResponseBody
    public List<Action>addActions(@RequestBody List<Action> listeActions) {
        List<Action> actions= examenService.addActions( listeActions);
        return actions;
    }

    @PostMapping("/add-Portefeuille")
    @ResponseBody
    public Portefeuille addPortefeuilleWIthElements(@RequestBody Portefeuille portefeuille) {
        Portefeuille portefeuillee= examenService.addPortefeuilleWIthElements(portefeuille);
        return portefeuillee;
    }

//    @PostMapping("/add-famille")
//    @ResponseBody
//    public FamilleActe ajouterFamilleActeEtActeAssocie(@RequestBody FamilleActe facte) {
//        FamilleActe familleActe= examenService.ajouterFamilleActeEtActeAssocie(facte);
//        return familleActe;
//    }

//    @PostMapping("/add-coursClassroom/{classe-id}")
//    public CoursClassroom addCoursClassroom(@RequestBody CoursClassroom cc, @PathVariable("classe-id") Integer codeClasse) {
//        return examenService.ajouterCoursClassroom(cc, codeClasse);
//    }

    @PostMapping("/add-ordre/{sym-id}/{ref-id}")
    public Ordre addOrdreAndAffectToAcionAndPortefeuille(@RequestBody Ordre ordre,@PathVariable("sym-id") String symbole,@PathVariable("ref-id") Integer reference){
        return examenService.addOrdreAndAffectToAcionAndPortefeuille( ordre,  symbole, reference);
    }


}
