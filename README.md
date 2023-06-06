# Social Brothers Assessment

## Opstarten
### Vereisten
Zorg ervoor dat een IDE geïnstalleerd is op je apparaat dat het .NET framework kan lezen en runnen, bijvoorbeeld [Visual Studio](https://visualstudio.microsoft.com/downloads/).

### Installatie en runnen
1. Clone het project via een client naar keuze: `https://github.com/annadame/SocialBrothersAssessment.git`.
2. Open de solution in je IDE.
3. Build en run het project en een Swagger implementatie zal zich openen in de browser, klaar voor het testen.


## Gebruik
<strong>Filteren en sorteren</strong>  
Deze functionaliteiten zitten ingebouwd in het `GET /addresses` endpoint. Voor het filter kan een woord of cijfer ingevoerd worden en alle adressen in de database die een veld hebben dat matched met deze query, worden gereturned. Om te sorteren dient exact (hoofdletter gevoelig, en alle velden beginnen ook met hoofdletter) het juiste veld mee gegeven te worden in combinatie met of het in oplopende of aflopende volgorde moet. Voorbeelden:  
`HouseNumber;asc`  
`ZipCode;desc`


<strong>Afstanden berekenen</strong>  
Het endpoint `GET /addresses/distance` geeft de afstand terug tussen twee adressen, berekend met de [DistanceMatrix API](https://distancematrix.ai/). Je geeft 2 bestaande id's mee van adressen die in de database staan, en krijgt o.a. de afstand in kilometers terug.

Note: momenteel staat de API key in `app.config` ook in de GitHub repository, voor het gemak. Normaliter zou ik dit bestand niet op de GitHub plaatsen, maar een uitleg geven hoe en waar de key lokaal op te slaan. De huidige key is geldig t/m 06/06/2023.


## Reflectie
### Tevreden
In het algemeen ben ik tevreden over de structuur van het project / hoe het opgezet is. Er zijn duidelijke model en controller lagen en daarnaast vind ik de code gestructureerd en leesbaar. Uiteraard hielp daarbij ook dat het een eenvoudige API is.

Ook ben ik blij met hoe dynamisch het filteren en sorteren is. Een veld meer of minder zal niet voor problemen in de code zorgen.

### Minder tevreden
Tegelijkertijd ben ik ook minder tevreden met de implementatie van het filteren en sorteren, aangezien ik type reflection gebruik en dit kan traag zijn. Dit was alleen voor nu de enige dynamische oplossing die ik kon bedenken.

Ook had ik graag een niet case sensitive sortering ingebouwd zodat de functionaliteit gebruiksvriendelijker is, maar dit was niet mogelijk met hoe ik het nu geïmplementeerd heb.
