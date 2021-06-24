$(document)
  .ready(function () {



      $('#btnAdd')
          .click(function () {

              var num = $('.property-fields__row').length
              var newNum = num + 1
              var newElem = $('#property-fields__row-1')
                  .clone()
                  .attr('id', 'property-fields__row-' + newNum)


              newElem.find('.line-item-property__companyName label')
                  .attr('for', 'CompanyNameId')
                  .val('')
              newElem.find('.line-item-property__companyName input')
                  .attr('id', 'CompanyNameId')
                  .attr('name', 'CompanyName')
                  .val('')

              newElem.find('.line-item-property__position label')
                  .attr('for', 'positionId')
                  .val('')
              newElem.find('.line-item-property__position input')
                  .attr('id', 'positionId')
                  .attr('name', 'PositionName')
                  .val('')

              newElem.find('.line-item-property__salary label')
                  .attr('for', 'salaryId')
                  .val('')
              newElem.find('.line-item-property__salary input')
                  .attr('id', 'salaryId')
                  .attr('name', 'Salary')
                  .val('')

              newElem.find('.line-item-property__enteringTime label')
                  .attr('for', 'WhenStartedId')
                  .val('')
              newElem.find('.line-item-property__enteringTime input')
                  .attr('id', 'WhenStartedId')
                  .attr('name', 'WhenStarted')
                  .val('')

              newElem.find('.line-item-property__exitTime label')
                  .attr('for', 'WhenLeftId')
                  .val('')
              newElem.find('.line-item-property__exitTime input')
                  .attr('id', 'WhenLeftId')
                  .attr('name', 'WhenLeft')
                  .val('')

              newElem.find('.line-item-property__reason label')
                  .attr('for', 'ReasonId')
                  .val('')
              newElem.find('.line-item-property__reason textarea')
                  .attr('id', 'ReasonId')
                  .attr('name', 'Reason')
                  .val('')


              $('#property-fields__row-' + num)
                  .after(newElem)

              $('#btnDel')
                  .attr('disabled', false)

              if (newNum === 19) {
                  $('#btnAdd')
                      .attr('disabled', 'disabled')
              }

          })


    

    $('#btnDel')
      .click(function () {
        var num = $('.property-fields__row').length

        $('#property-fields__row-' + num)
          .remove()

        $('#btnAdd')
          .attr('disabled', false)

        if (num - 1 === 1) {
          $('#btnDel')
            .attr('disabled', 'disabled')
        }

      })
  })

$('.addOldWork')
  .click(function () {
    $(this)
      .next('.dropdown-content')
      .slideToggle(550)
  })

function myFunction() {
  document.getElementById('myDropdown')
    .classList
    .toggle('show')
}

window.onclick = function (event) {
    if (!event.target.matches('.addOldWork')) {
      var dropdowns = document.getElementsByClassName('dropdown-content')
      var i
      for (i = 0; i < dropdowns.length; i++) {
        var openDropdown = dropdowns[i]
        if (openDropdown.classList.contains('show')) {

        }
      }
    }
  }

//  document.getElementById('addWork')
//    .addEventListener('click', function (event) {
//      event.preventDefault()
//    })
//document.getElementById('removeBtn')
//  .addEventListener('click', function (event) {
//    event.preventDefault()
//  })

$('#removeBtn')
  .bind('click', function () {
    $('input[type=text], textarea')
      .val('')
    window.location.reload()
  })



$(function () {
  $('#dateOfIssue')
    .datepicker()
})
$(function () {
  $('#endDate')
    .datepicker()
})
$(function () {
  $('#dateOfBirth')
    .datepicker()
})


$(function () {
  $('#enteringTime')
    .datepicker()
})

$(function () {
  $('#exitTime')
    .datepicker()
})


