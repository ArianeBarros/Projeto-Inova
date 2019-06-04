document.body.style.backgroundSize =  '100%';
document.body.style.backgroundPosition = 'fixed'
function exibirHome()
{
    document.getElementById("conteudo").innerHTML = '';
    document.getElementById("obs").innerHTML = '';
    window.location.href = "/";
}
var indexAtual = -1;
trocarSlide(indexAtual)
function trocarSlide(index)
{
    var labels = $(".selector");
    if (index >= labels.length || index < 0) index = 0;
    {
        $("input[name=r]").prop('checked', false); //pintar o btn la
        labels.removeClass('selectedBar').addClass('bar');
        $(labels[index]).addClass('selectedBar')
        $(labels[index]).removeClass('bar')
        indexAtual = index;
        if (index == 1 || index == 0)
            $("#s1").prop('style', `margin-left: -${index * 25}%;`); //margin left
        else
            if (index ==2)
                $("#s1").prop('style', `margin-left: -${index * 22.5}%;`); //margin left
            else
                if (index == 3)
                    $("#s1").prop('style', `margin-left: -${index * 21.6666}%;`); //margin left
                else
                    if (index == 4)
                        $("#s1").prop('style', `margin-left: -${index * 21.2666}%;`); //margin left
                    else
                        if (index == 5)
                            $("#s1").prop('style', `margin-left: -${index * 21}%;`); //margin left
        // na teoria, quanto de margin-left teria o segundo slide com esse método? -1 * 100% === -100%
        //20% --> 40% --> 60% --> 80%
    }
}
setInterval(function(){trocarSlide(++indexAtual)}, 7000)

if (screen.width < 640)
{
    $("#slidersh").toggleClass("middleMob");
}