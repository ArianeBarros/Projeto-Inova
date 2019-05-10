window.onload = function () {
    Organiza();
}

var qualId = null;
var qualImg = null;

function CarregarDadosBD() {
    var string = window.location.href.substring(39);
    string = string.split("?");
    qualId = string[0];
    string = string[1];
    string = string.split("&");
    var nome = string[0].substring(5);
    qualImg = string[1].substring(7);

    while (nome.indexOf("%20") != -1)
        nome = nome.replace("%20", " ");
    while (qualImg.indexOf("%2F") != -1)
        qualImg = qualImg.replace("%2F", "/");


    //alert(nome);
    //alert(qualImg);
    //alert(qualId);

    document.getElementById("opcoesFotos").innerHTML = "<input id=\"btnPerfil\" type=\"image\" src='" + qualImg + "' onclick=\"CarregarPerfil()\">";
}

function Organiza() {
    var h1 = document.getElementById("h1");
    var info = document.getElementById("info");
    var conj = document.getElementById("conj");
    h1.style.position = "relative";
    //h1.style.top = "350em";
    if (window.innerWidth >= 800) {
        info.style.display = "initial";
        conj.style.display = "none";
        var fundo = document.getElementById("ondas");
        fundo.src = "/Imagens/ondas2.png";
        fundo.style.left = "0%";
        // fundo.style.top = "-50px";

        var formiga = document.getElementById("formiga");
        formiga.style.display = "initial";
        formiga.style.width = "15%";
        formiga.style.top = "1.5em";
        formiga.style.left = "15%";

        var form = document.getElementById("form");
        form.style.top = "-22em";
        form.style.height = "15em";

        var comp = document.getElementById("compromisso");
        comp.style.top = "-18em";
        comp.style.height = "15em";

        var maos = document.getElementById("maos");
        maos.style.display = "initial";
        maos.style.width = "39%";
        maos.style.position = "relative";
        maos.style.left = "5%";
        //maos.style.top = "1em";

        var h1 = document.getElementById("h1");
        h1.style.paddingLeft = "35%";
        h1.style.top = "-7.5em";
        h1.style.fontSize = "25px";
        var h2 = document.getElementById("h2");
        h2.style.paddingLeft = "35%";
        h2.style.top = "-7em";
        h2.style.fontSize = "22px";
        h1.style.position = "relative";

        h2.style.position = "relative";
       // var carinha = document.getElementById("compromisso");
       // carinha.style.top = "-30%";
        //carinha.style.height = "15em";
        var info = document.getElementById("info");
        info.style.width = "100%";
        info.style.position = "relative";
        info.style.top = "-10em";
        var h3 = document.getElementById("h3");
        h3.style.top = "-9em";
        h3.style.padding = "0px";
        h3.style.paddingLeft = "50%";
        h3.style.fontSize = "25px";
        var h4 = document.getElementById("h4");
        h4.style.paddingLeft = "50%";
        h4.style.fontSize = "22px";
        h4.style.top = "-9em";

        var mundo = document.getElementById("globalizacao");
        var h5 = document.getElementById("h5");
        h5.style.paddingLeft = "50%";
        h5.style.fontSize = "25px";
        var h6 = document.getElementById("h6");
        h6.style.paddingLeft = "50%";
        h6.style.fontSize = "22px";
        h6.style.top = "-8em";
        

        if (window.innerWidth >= 1000) {
            formiga.style.width = "12%";

            var maos = document.getElementById("maos");
            maos.style.width = "30%"

            form.style.top = "-20em";
            h1.style.position = "relative";
            h2.style.position = "relative";
            h1.style.top = "-7em";
            h1.style.fontSize = "28px";
            h1.style.paddingLeft = "20%";
            h2.style.position = "relative";
            h2.style.top = "-6.8em";
            h2.style.fontSize = "25px";
            h2.style.paddingLeft = "20%";
            h3.style.fontSize = "27.43px";
            h3.style.paddingTop = "2%";
            h3.style.paddingLeft = "27%";
            h3.style.width = "70%";
            h4.style.fontSize = "25px";
            h4.style.paddingLeft = "27%";
            h4.style.paddingTop = "0.3%";
            h4.style.width = "63%";
            h5.style.fontSize = "27.43px";
            h6.style.fontSize = "25px";

            if (window.innerWidth >= 1300) {
                h1.style.paddingTop = "0em";
                h1.style.paddingBottom = "0em";
                h2.style.paddingBottom = "0em";
                h1.style.position = "relative";
                h2.style.position = "relative";
                h1.style.top = "-7em";
                h1.style.paddingLeft = "20%";
                formiga.style.width = "10%";
                formiga.style.top = "1em";
                h2.style.top = "-6.8em";
                h2.style.paddingLeft = "20%";
                h3.style.top = "-9em";
                h3.style.paddingLeft = "28%";
                h3.style.width = "60%";
                h4.style.fontSize = "25px";
                h4.style.paddingLeft = "28%";
                h4.style.top = "-9em";
                h4.style.width = "60%";
                h6.style.fontSize = "25px";
                maos.style.width = "24%";
                maos.style.left = "10%";

            }
        }
    }
    else {
        var fundo = document.getElementById("ondas");
        fundo.src = '/Imagens/ondas.png';
        var botao = document.getElementById("comece");
        botao.style.width = "35%";
        botao.style.top = "6em";
        var h1 = document.getElementById("h1");
        h1.style.fontSize = "24px";
       // h3.style.fontSize = "24px";
        //h3.style.fontSize = "24px";
        var h2 = document.getElementById("h2");
        h2.style.fontSize = "20px";
        //h4.style.fontSize = "20px";
        //h4.style.fontSize = "20px";
        h2.style.paddingLeft = "40%";
        var h4 = document.getElementById("h4");
        h2.style.top = "-8em";
        h1.style.position = "relative";
        h2.style.position = "relative";
        //comp.style.top = "0em";


        if (window.innerWidth >= 600) {
            info.style.display = "initial";
            conj.style.display = "none";
            var fundo = document.getElementById("ondas");
            fundo.style.left = "-10%";
            var formiga = document.getElementById("formiga");
            formiga.style.display = "initial";
            formiga.style.width = "20%";
            formiga.style.left = "10%";
            var maos = document.getElementById("maos");
            maos.style.display = "initial";
            maos.style.width = "50%";
            maos.style.position = "relative";
            maos.style.left = "3%";
           // var cara = document.getElementById("maos");
           // cara.style.display = "initial";
            var coisa = document.getElementById("coisa2");
            coisa.src = '/Imagens/coisinhas2.png';
            coisa.style.top = "9.7em";
            coisa.style.width = "90%";
            coisa.style.left = "3%";
            var frase = document.getElementById("frase");
            frase.style.top = "4em";
            frase.style.left = "10%";
            var botao = document.getElementById("comece");
            botao.style.left = "65%";
            var form = document.getElementById("form");
            form.style.top = "-9.8em";
            form.style.height = "15em";
            var comp = document.getElementById("compromisso");
            comp.style.height = "15em";
            comp.style.top = "-5em";
            //var carinha = document.getElementById("compromisso");
            //carinha.style.top = "0%";
            var h1 = document.getElementById("h1");
            h1.style.top = "-8em";
            h1.style.padding = "0px";
            h1.style.paddingLeft = "40%";
            h1.style.width = "60%";
            h2.style.top = "-9em";
            h2.style.width = "60%";
            var h3 = document.getElementById("h3");
            h3.style.position = "relative";
            h3.style.paddingLeft = "55%";
            h3.style.top = "-9.5em";
            h3.style.width = "45%";
            h3.style.paddingBottom = "0px";
            h3.style.paddingTop = "0px";
            h3.style.fontSize = "23px";
            var h4 = document.getElementById("h4");
            h4.style.paddingLeft = "55%";
            h4.style.top = "-11em";
            h4.style.fontSize = "19px";
            h4.style.width = "45%";
            info.style.display = "none";
            conj.style.display = "initial";
            // var cabecalho = document.getElementById("header");
            //cabecalho.style.width = "80%";
        }
        else {
            var comp = document.getElementById("compromisso");
            comp.style.height = "11em";
            h1.style.position = "relative";
            h2.style.position = "relative";
            var fundo = document.getElementById("ondas");
            fundo.style.left = "-30%";
            var formiga = document.getElementById("formiga");
            formiga.style.display = "none";
            var maos = document.getElementById("maos");
            maos.style.display = "none";
            var coisa = document.getElementById("coisa2");
            coisa.src = '/Imagens/coisinhas.png';
            coisa.style.top = "5.4em";
            coisa.style.width = "77%";
            coisa.style.left = "12%";
            var frase = document.getElementById("frase");
            frase.style.top = "1.5em";
            frase.style.left = "20%";
            var botao = document.getElementById("comece");
            botao.style.left = "30%";
            botao.style.top = "5.3em";
            var form = document.getElementById("form");
            form.style.top = "-12.8em";
            form.style.height = "11em";
            
            var h1 = document.getElementById("h1");
            h1.style.position = "relative";
            h1.style.paddingLeft = "10%";
            h1.style.paddingTop = "1.5em";
            h1.style.paddingBottom = "0.5em";
            h1.style.fontSize = "18px";
            h1.style.top = "0px";
            h1.style.width = "90%";

            var h2 = document.getElementById("h2");
            h2.style.paddingLeft = "10%";
            h2.style.paddingBottom = "1em";
            h2.style.fontSize = "16px";
            h2.style.top = "0px";
            h2.style.width = "90%";

            var h3 = document.getElementById("h3");
            h3.style.top = "0em";
            h3.style.width = "89%";
            h3.style.paddingLeft = "40px";
            h3.style.paddingTop = "40px";
            h3.style.paddingBottom = "10px";
            h3.style.fontSize = "18px";

            var h4 = document.getElementById("h4");
            h4.style.paddingLeft = "40px";
            h4.style.top = "11em";
            h4.style.width = "89%";
            h4.style.fontSize = "16px";

            info.style.display = "none";
            conj.style.display = "initial";

            var infor = document.getElementById("globalizacao");
            infor.style.top = "22em";

            var plan = document.getElementById("plan");
            plan.style.position = "relative";
            plan.style.paddingTop = "2em";
            var list = document.getElementById("list");
        }
    }
}


window.onresize = function () {
    Organiza();
}