$(function () {
    $.contextMenu({
        selector: '.context-menu-one',
        callback: function (key, options) {
            var id =(options.$trigger.attr("id"));
            operacao(key, id);
        },
        items: {
            "cadastrar": { name: "Cadastrar", icon: "fas fa-plus" },
            "alterar": { name: "Alterar", icon: "far fa-edit" },
            "excluir": { name: "Excluir", icon: "far fa-trash-alt", class:"menu-icon-delete" }
        }

    });

    $('.context-menu-one').on('click', function (e) {
        console.log('clickedee', this);
    })
});

function operacao(op, id) {
    switch (op) {
        case "cadastrar": window.location.href = obterController() + "/" + "Cadastrar";
            break;
        case "alterar": window.location.href = obterController() + "/Alterar?id=" + id;
            break;
        case "excluir": 
            confirmarExclusao(id);
            break;
        default:
            alert("operação não encontrada");
    }
}

function confirmarExclusao(id) {
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: 'btn btn-success',
            cancelButton: 'btn btn-danger mr-2'
        },
        buttonsStyling: false
    })

    swalWithBootstrapButtons.fire({
        title: 'Tem certeza?',
        text: "Você não poderá reverter essa operação!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Sim, Excluir!',
        cancelButtonText: 'Cancelar',
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            //var formulario = new FormData();
            //formulario.append("id", id);
            
            $.ajax({
                type: "GET",
                url: obterController() + "/Excluir?id=" + id,
/*                data: formulario,*/
                contentType: false,
                processData: false, // não realizar a validação dos dados enviados
                error: function () {
                    alert("Erro ao realizar a operação!");
                },
                success: function () {
                    Swal.fire({
                        icon: 'success',
                        title: 'Registro excluído com sucesso.',
                        confirmButtonText: 'Excluído',
                    }).then((result) => {
                        if (result.isConfirmed) {
                            window.location.reload()
                        }
                    })
                }
            });
        } else if (
            result.dismiss === Swal.DismissReason.cancel
        ) {
            swalWithBootstrapButtons.fire(
                'Cancelado',
                'Seu registro está seguro =)',
                'error'
            )
        }
    })
}

function obterController() {
    const urlSplit = window.location.pathname.split("/");
    var controller = urlSplit[2];
    return controller;
}

// ainda não utilizei em nenhum local
//function obterArea() { 
//    const urlSplit = window.location.pathname.split("/");
//    var area = urlSplit[1];
//    return area;
//}


// INICIO - Cadastro de Disiciplinas
function defaultZero(elementoInput)
{
    if (elementoInput.valueAsNumber && (parseInt(elementoInput.value) > 0))  {
        return parseInt(elementoInput.value);
    } else {
        elementoInput.value = 0;
        return 0;
    }
}

function cadDisciplinaCalcCh()
{
    var chPresencialTeorica = defaultZero(document.getElementById('chPresencialTeorica'))
    var chPresencialPratica = defaultZero(document.getElementById('chPresencialPratica'));
    var chEadPratica = defaultZero(document.getElementById('chEadPratica'));
    var chEadTeorica = defaultZero(document.getElementById('chEadTeorica'));
    var chEstudo = defaultZero(document.getElementById('chEstudo'));

    var ch = chPresencialTeorica + chPresencialPratica + chEadPratica + chEadTeorica + chEstudo
    document.getElementById('ch').value = ch;
}

// TÉRMINO - Cadastro de Disiciplinas