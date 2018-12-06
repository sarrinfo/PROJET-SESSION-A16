/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author SARRINFO
 */


import DAO.AdresseDAO;
import DAO.AnnonceDAO;
import DAO.BienImmobilierDAO;
import DAO.ClientDAO;
import DAO.EmployeDAO;
import DAO.HibernateUtil;
import DAO.ImageDAO;
import DAO.ImmeubleDAO;
import DAO.UtilisateurDAO;
import DAO.VisiteDAO;
import Modele.Adresse;
import Modele.AdresseId;
import Modele.Bienimmobilier;
import Modele.BienimmobilierId;
import Modele.Annonce;
import Modele.Client;
import Modele.Employe;
import Modele.GestionnaireVisite;
import Modele.Image;
import Modele.ImageId;
import Modele.Immeuble;
import Modele.Utilisateur;
import Modele.UtilisateurId;
import Modele.Visite;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;
import java.math.BigDecimal;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.List;


/**
 *
 * @author SARRINFO
 */
public class Test {
    public static void main (String []args ){
        
        Adresse add = new Adresse(new AdresseId("H1Z-1R2", 4150), "45e Rue", 
                "cote des neiges","Montreal");
        Immeuble imm = new Immeuble("R001", add, "Residentiel");

        Adresse add1 = new Adresse(new AdresseId("H8M-4T2", 10150), "Beaubien", 
                "Mont royal","Montreal");
        Immeuble imm1 = new Immeuble("R002", add1, "Residentiel");
        
        Adresse add2 = new Adresse(new AdresseId("H3N-2T6", 3750), "Fleury", 
                "Anjou","Montreal");
        Immeuble imm2 = new Immeuble("C001", add2 , "Commerce");
//        
//        AdresseDAO.insert(add);
//        AdresseDAO.insert(add1);
//        AdresseDAO.insert(add2);
//        
//        ImmeubleDAO.insert(imm);
//        ImmeubleDAO.insert(imm1);
//        ImmeubleDAO.insert(imm2);
//        
//        
        Bienimmobilier bien = new Bienimmobilier(new BienimmobilierId(10001,"R001")
                , imm, "Appart", new BigDecimal(800));
        Bienimmobilier bien1 = new Bienimmobilier(new BienimmobilierId(10002,"R001")
                , imm, "Appart", new BigDecimal(750));
        Bienimmobilier bien2 = new Bienimmobilier(new BienimmobilierId(20001,"R002")
                , imm, "Appart", new BigDecimal(850));
         Bienimmobilier bien3 = new Bienimmobilier(new BienimmobilierId(10001,"C001")
                , imm, "Bureau", new BigDecimal(900));
        Bienimmobilier bien4 = new Bienimmobilier(new BienimmobilierId(10002,"C001")
                , imm, "Bureau", new BigDecimal(650));
        Bienimmobilier bien5 = new Bienimmobilier(new BienimmobilierId(20002,"R002")
                , imm, "Appart", new BigDecimal(900));
        
//        BienImmobilierDAO.insert(bien);
//        BienImmobilierDAO.insert(bien1);
//        BienImmobilierDAO.insert(bien3);
//        BienImmobilierDAO.insert(bien2);
//        BienImmobilierDAO.insert(bien4);
//        BienImmobilierDAO.insert(bien5);
//        
////        Image img = new Image(new ImageId("R001",10001,0));
////        Image img1 = new Image(new ImageId("R001",10001,1));
////        Image img2 = new Image(new ImageId("R001",10001,2));
////        Image img3 = new Image(new ImageId("R001",10001,3));
////        Image img4 = new Image(new ImageId("R001",10001,4));
////        ImageDAO.insert(img);
////        ImageDAO.insert(img1);
////        ImageDAO.insert(img2);
////        ImageDAO.insert(img3);
////        ImageDAO.insert(img4);
////      
////        img = new Image(new ImageId("R001",10002,0));
////        img1 = new Image(new ImageId("R001",10002,1));
////        img2 = new Image(new ImageId("R001",10002,2));
////        img3 = new Image(new ImageId("R001",10002,3));
////        img4 = new Image(new ImageId("R001",10002,4));
////        ImageDAO.insert(img);
////        ImageDAO.insert(img1);
////        ImageDAO.insert(img2);
////        ImageDAO.insert(img3);
////        ImageDAO.insert(img4);
////       
////        img = new Image(new ImageId("C001",10002,0));
////        img1 = new Image(new ImageId("C001",10002,1));
////        img2 = new Image(new ImageId("C001",10002,2));
////        img3 = new Image(new ImageId("C001",10002,3));
////        img4 = new Image(new ImageId("C001",10002,4));
////        ImageDAO.insert(img);
////        ImageDAO.insert(img1);
////        ImageDAO.insert(img2);
////        ImageDAO.insert(img3);
////        ImageDAO.insert(img4);
//        
//     
        Date date = new Date("2018/07/06");
        Calendar cal = Calendar.getInstance();
        cal.setTime(date);
        Annonce ann = new Annonce(10001,bien, "Grand 4 1/2 pres de la station Henri Bourassa"
                + "",4,2,300,date,"chauffage inclus, frigo et poele","internet"," "
                        + "proche du metro Henri Bourassa"," Parking sous sol");
        
//        AnnonceDAO.insert(ann);
       
        Employe emp = new Employe("MB001", "Mathieu", "Baudin");
//        EmployeDAO.insert(emp);

        date = new Date("2018/07/10");
        cal = Calendar.getInstance();
        cal.setTime(date);
        ann = new Annonce(10002,bien1, "4 1/2 pres station Cote vertu"
                + "",4,1,400,date,"chauffage inclus, frigo et poele","internet"," "
                        + "proche du metro station Cote vertu"," Parking gratuit");
        
//        AnnonceDAO.insert(ann);
       
        emp = new Employe("CK002", "CESAR", "KOUASSI");
//        EmployeDAO.insert(emp);

        date = new Date("2018/10/25");
        cal = Calendar.getInstance();
        cal.setTime(date);
        ann = new Annonce(10003,bien2, "3 1/2 proche du centre commercial"
                + "",4,1,400,date,"chauffage inclus, frigo et poele","internet tres haut debit"," "
                        + "proche du metro tout commerce"," Parking disponible");
        
//        AnnonceDAO.insert(ann);
       
        emp = new Employe("IS003", "SARR", "IBRAHIMA");
//        EmployeDAO.insert(emp);

        date = new Date("2018/01/30");
        cal = Calendar.getInstance();
        cal.setTime(date);
        ann = new Annonce(10004,bien3, "4 1/2 proche du parc Angrignon"
                + "",4,2,00,date,"chauffage inclus, frigo et poele","internet inclus"," "
                        + "proche du parc Angrignon"," Parking disponible");
        
//        AnnonceDAO.insert(ann);
       
        emp = new Employe("AM004", "SOW", "AMADOU");
//        EmployeDAO.insert(emp);









        Date date1 = new Date("2018/10/10 09:00");
        Date date2 = new Date("2018/10/12 10:00");
        Date date3 = new Date("2018/10/15 12:00");
        Date date4 = new Date("2018/10/25 15:00");
        Date date5 = new Date("2018/10/31 17:00");
        Calendar cal1 = Calendar.getInstance();
        cal1.setTime(date1);
        cal1.setTime(date2);
        cal1.setTime(date3);
        cal1.setTime(date4);
        cal1.setTime(date5);
        Visite visite = new Visite(date1, emp, bien);
        Visite visite1 = new Visite(date2, emp, bien);
        Visite visite2 = new Visite(date3, emp, bien);
        Visite visite3 = new Visite(date4, emp, bien);
        Visite visite4 = new Visite(date5, emp, bien);
//        VisiteDAO.insert(visite);
//        VisiteDAO.insert(visite1);
//        VisiteDAO.insert(visite2);
//        VisiteDAO.insert(visite3);
//        VisiteDAO.insert(visite4);
        
        date1 = new Date("2018/11/13 09:00");
        date2 = new Date("2018/11/22 10:00");
        date3 = new Date("2018/11/07 12:00");
        date4 = new Date("2018/11/08 15:00");
        date5 = new Date("2018/11/06 17:00");
        cal1 = Calendar.getInstance();
        cal1.setTime(date1);
        cal1.setTime(date2);
        cal1.setTime(date3);
        cal1.setTime(date4);
        cal1.setTime(date5);
        visite = new Visite(date1, emp, bien1);
        visite1 = new Visite(date2, emp, bien1);
        visite2 = new Visite(date3, emp, bien1);
        visite3 = new Visite(date4, emp, bien1);
        visite4 = new Visite(date5, emp, bien1);
//
//        VisiteDAO.insert(visite);
//        VisiteDAO.insert(visite1);
//        VisiteDAO.insert(visite2);
//        VisiteDAO.insert(visite3);
//        VisiteDAO.insert(visite4);

        date1 = new Date("2018/09/13 09:00");
        date2 = new Date("2018/03/22 10:00");
        date3 = new Date("2018/04/07 12:00");
        date4 = new Date("2018/07/08 15:00");
        date5 = new Date("2018/03/06 17:00");
        cal1 = Calendar.getInstance();
        cal1.setTime(date1);
        cal1.setTime(date2);
        cal1.setTime(date3);
        cal1.setTime(date4);
        cal1.setTime(date5);
        visite = new Visite(date1, emp, bien2);
        visite1 = new Visite(date2, emp, bien2);
        visite2 = new Visite(date3, emp, bien2);
        visite3 = new Visite(date4, emp, bien3);
        visite4 = new Visite(date5, emp, bien3);
//
        VisiteDAO.insert(visite);
        VisiteDAO.insert(visite1);
        VisiteDAO.insert(visite2);
        VisiteDAO.insert(visite3);
        VisiteDAO.insert(visite4);
        
       Client client = new Client("CK0001","CESAR","KOUASSI","4388252933","KCESAR@hotmail.com"); 
//       ClientDAO.insert(client);
//       VisiteDAO.update(visite, client);


//       Utilisateur user = new Utilisateur(new UtilisateurId("SARR","sarrinfo@yahoo.fr"), "123456789");
////       UtilisateurDAO.insert(user);
//        GsonBuilder builder = new GsonBuilder();
//        Gson gson = builder.create();
//       
//        String s = "[ ";
//        List <Bienimmobilier> bien7 = BienImmobilierDAO.allBienImmobiliers();
//        for(int i=0; i <bien7.size(); i++){
//
//            s += bien7.get(i).toString();
//        }
//        s += " null ]";
//        System.out.print(gson.toJson(bien7.toString()));
//        
        
        
        
        
        
//        List <Bienimmobilier> list= BienImmobilierDAO.allBienImmobiliers();
//        for(Bienimmobilier line : list ){
//            System.out.println("ID : "+line.getTypeBienimmobilier());
//            System.out.println("Prix : "+line.getPrixLoyer()); 
//            
//        }



//        SimpleDateFormat dateFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm");
//        dateFormat.setTimeZone(cal.getTimeZone());
//        System.out.println(dateFormat.format(cal.getTime()));

        //exemple calendar format conversion     
//        String dateInString = "31-02-2017";
//        date = dateFormat.parse(dateInString);
//        System.out.println("dernier " + date);

//GestionnaireVisite ges = new GestionnaireVisite();
//String date10 = "2018-10-20 09:00";
//Date date50 = ges.formaterDate(date10);
//ges.gererListVisite(date50);
////visite = VisiteDAO.simpleVisite(date50);
////     System.out.println("Visite "+ges.rechercherVisite(visite));
//String date11 = "2018-10-12 10:00";
//Date date51 = ges.formaterDate(date11);
//ges.gererListVisite(date51);


//ges.ajouterVisite(visite);
//ges.ajouterVisite(visite1);
//ges.ajouterVisite(visite2);
//
//System.out.println(ges.rechercherVisite(visite));
           

//           System.out.println(vis.toString());
       
        
        HibernateUtil.getSessionFactory().close();
    
    }
//     public static boolean rechercherVisite(Visite visite, Visite visite2) {
//        boolean existe = false;
//        if(visite.getDatevisite().compareTo(visite2.getDatevisite())==0){
//            existe = true;
//        }
//        return existe;
//    }
}
