# PlantiLoc

Relazione Finale
Marco Landi (MAT. 320435)
Ingegneria dei Sistemi Informativi, Tecniche di Sviluppo Software in Ambiente Industriale

PlantiLoc

In sintesi, PlantiLoc è un’applicazione asp.net MVC per la paesaggistica che permette di ordinare delle piante, farle piantare in specifiche coordinate geografiche e, inoltre, portare a termine ordini.

Descrizione degli strumenti usati:

Il progetto è basato sul linguaggio di programmazione C#. C# è stato sviluppato da Microsoft e supporta tutti i concetti della programmazione orientata agli oggetti.

Ho usato i seguenti stumenti:
	- PC con windows 11
	- C#  (linguaggio di programmazione usato per scrivere gran parte dell’applicazione)
	- JavaScript  (linguaggio di programmazione usato per interagire con pagine web)
	- CSS  (linguaggio di programmazione usato per definire la formattazione di documenti HTML)
	- LINQ (funzionalità query)
	- Entity Framework (funzionalità di accesso ai dati)
	- Console di gestione pacchetti Nuget (per digitare comandi e istallare pacchetti)
	- VisualStudio Enterprise 2019 (ambiente di sviluppo)
- Microsoft SQL Server con Microsoft SQL server management studio (per avere un Database comunicante con l’applicazione asp.net MVC)
	- GitHub (per creare repository contenente il progetto)
	- Migrations (consente di usare approccio code-first per l’evoluzione del database)
	- Servizi WCF (per consentire comunicazione tra le entità)
	- Google API (per incorporare mappa e visualizzazione coordinate onclick)





Descrizione Funzionamento: 

•	Login obbligatorio (disponibile grazie a authentication: individual user accounts)
•	Bisogna registrarsi come paesaggista/giardiniere/entrambi
•	paesaggisti: ordinano piante indicando coordinate geografiche in cui desiderano che esse vengano piantate e temine (data con minimo 3 giorni di preavviso)
•	Giardinieri: si registrano ad un ordine per portarlo a termine trarne un guadagno in base alla taglia della pianta che devono impiantare
•	Solamente l'amministratore del sito (admin@progetto.com, user con ruolo "CanManagePlants") ha la possibilità di apportare modifiche alle piante nel database 		(aggiungere/rimuovere pianta).
•	Classifica di giardinieri indicante per ciascun giardiniere il numero di ordini eseguiti e guadagno totale
•	Classifica di paesaggisti indicante per ciascun paesaggista il numero di ordini commessi e spesa totale
•	ordini, piante (solo admin), giardinieri e paesaggisti possono venire aggiunti ed eliminati
•	Possibilità di accedere con Facebook
•	Le tabelle comprendono una barra di ricerca ed è possibile anche ordinare i record dalla tabella in base al campo (colonna) su cui clicco
•	Gestione degli errori nel caso in cui i dati inseriti da un utente non siano ammissibili
•	Esempio: nel caso in cui un giardiniere voglia prendersi carico di un ordine già preso in carico da un altro giardiniere, gli verrà comunicato che tale 	ordine è già stato preso in carico
•	Esempio: nel caso in cui un paesaggista voglia ordinare una pianta con un termine minore di 3 giorni, gli verrà comunicato sotto il textbox che sono 		richiesti minimo 3 giorni di preavviso dalla data odierna
