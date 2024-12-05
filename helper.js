


var bodyApp = Array.from(document.getElementsByTagName("frame")).find( el => el.title=="contenu").contentDocument

////////////////////////////////// Helper //////////////////////////////////

/** https://stackoverflow.com/questions/10596417/is-there-a-way-to-get-element-by-xpath-using-javascript-in-selenium-webdriver   */
var getElementByXpath = (path) => bodyApp.evaluate(path, bodyApp, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
	
var getElementsByXpath = (xpath) => {
		let listResult = [];
		var result = bodyApp.evaluate(xpath, bodyApp, null, XPathResult.ANY_TYPE, null);
		while (node = result.iterateNext()) {
		 listResult.push(node);
		}
		return listResult;
}

////////////////////////////////// Script //////////////////////////////////

/** 
 * this is a CLI for auto fit value
 * funtion must be copy pasted at the beginning into the console
 * the call is dependent of the tab : 
 *   - bdc(1) for first tab.
 *   - bdc(go) for going to the next tab.
 * 
 * Remarks : 
 *  - bdc = Bon de commande 
 *  - dip = Dossier d'information personnelles
*/

// Alias
var go = "go";
var og = "og";

var nn = "nn"; // new tab 2


const sim = (select) => {
	if(select == null || select == go) getElementByXpath("//input[contains(@value,'Confirmer') or contains(@value,'Souscrire')]").click();
	if(select == 0) {
		getElementByXpath("//input[@value='MAISON']").click();
		getElementByXpath("//input[@value='P']").click();
		getElementByXpath("//input[@value='INTER']").click();
		
		getElementsByXpath("//input[@value='O']").forEach( (el) => el.click());
		sim(go)
	}
}
	
const _ = (select) => {
  if(select == null  || select == go)  getElementByXpath("//input[contains(@alt,'Valider') or contains(@alt,'Suivant')]").click();
  else if(select == og) getElementByXpath("//input[contains(@alt,'Précédent')]").click(); 
  else if(select == 0) {
	  getElementByXpath("//input[@value='CLIENT_CMCIC']").click();
	  _()
  }
  else if(select == 1) {
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref1").value="FR76";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref2").value="1027";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref3").value="8010";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref4").value="0100";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref5").value="0203";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref6").value="8590";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:ref7").value="691";
	  bodyApp.getElementById("PVOMXX-IBAN-COMP-EXT:cpl1").value="CMCIFRPPXXX";
	  bodyApp.getElementById("PVOMXX-CLI-TEL-NUM-DOM:num").value="+33659595959";
	  _()
  }
  else if(select == nn || select == 22){
	getElementByXpath("//span[.='Saisir un nouveau site']/parent::a").click();
  }
  else if(select == 2){
	bodyApp.getElementById("PVOMXX-SIT-ADR-RUE").value="18 Grand rue";
	bodyApp.getElementById("PVOMXX-SIT-ADR-RUE").select();
	
	bodyApp.getElementById("PVOMXX-SIT-ADR-CP").value="67000";
	bodyApp.getElementById("PVOMXX-SIT-ADR-CP").select();
	bodyApp.getElementById("PVOMXX-SIT-ADR-CP").focus();
	bodyApp.getElementById("PVOMXX-SIT-ADR-CP").click();
	
	bodyApp.getElementById("PVOMXX-SIT-ADR-LOC").value= "Strasbourg";
	bodyApp.getElementById("PVOMXX-SIT-ADR-LOC").select();
	bodyApp.getElementById("PVOMXX-SIT-ADR-LOC").focus();
	bodyApp.getElementById("PVOMXX-SIT-ADR-LOC").click();
	
	bodyApp.getElementById("PVOMXX-SIT-SFI").value= "59";
	bodyApp.getElementById("PVOMXX-SIT-SFI").select();
	bodyApp.getElementById("PVOMXX-SIT-SFI").focus();
	bodyApp.getElementById("PVOMXX-SIT-SFI").click();
	
	bodyApp.getElementById("PVOMXX-SIT-TEL-NUM-PRE:num").value = "0659595959";
	bodyApp.getElementById("PVOMXX-SIT-TEL-NUM-PRE:num").select();
	bodyApp.getElementById("PVOMXX-SIT-TEL-NUM-PRE:num").focus();
	bodyApp.getElementById("PVOMXX-SIT-TEL-NUM-PRE:num").click();
	_()
	}
	else if(select == 3) _();
	else if(select == 6){
		getElementByXpath("//input[contains(@value,'AUT')]").click();
	}
	else if(select == 66){
		getElementByXpath("//input[contains(@value,'ULT')]").click();
	}
	
  else console.log("unknow argument")
}  

const dip = (select) => {
  if(select == null || select == go) getElementByXpath("//input[contains(@alt,'Valider') or contains(@alt,'Suivant') or contains(@alt,'Confirmer')]").click();
  if(select == 1 ) dip();
  if(select == 2){
	bodyApp.getElementById("PVOMXX-MDC-TEL").value="0659595959";
	bodyApp.getElementById("PVOMXX-MDC-NOM").value="HYPPOLITE";
	bodyApp.getElementById("PVOMXX-MDC-PRN").value="SCOOBY";

	bodyApp.getElementById("PVOMXX-MDC-ADR-NUM").value="18";
	bodyApp.getElementById("PVOMXX-MDC-ADR-RUE").value="Grand Rue";

	bodyApp.getElementById("PVOMXX-MDC-ADR-CP").value="67700";
	bodyApp.getElementById("PVOMXX-MDC-ADR-LOC").value="Strasbourg";
	dip();
  }
  if(select == 3){
	 bodyApp.getElementById("PVOMXX-CTC-PRE-ADR-NUM").value="19";
	bodyApp.getElementById("PVOMXX-CTC-PRE-ADR-RUE").value="Grand rue";
	bodyApp.getElementById("PVOMXX-CTC-PRE-ADR-CP").value="67000";
	bodyApp.getElementById("PVOMXX-CTC-PRE-ADR-LOC").value="Strasbourg";
	bodyApp.getElementById("PVOMXX-CTC-PRE-TEL-NUM-DOM").value="0659594815";
	bodyApp.getElementById("PVOMXX-CTC-PRE-TPS").value="9";
	
	bodyApp.getElementById("PVOMXX-CTC-PRE-NOM").value="James";
	bodyApp.getElementById("PVOMXX-CTC-PRE-PRN").value="Bonbond";
	dip()
  }
  if(select == 4) dip()
	
  else console.log("unknow argument")
  
}  

