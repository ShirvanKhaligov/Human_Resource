$('.newCommand')
  .click(function () {
    $(this)
      .next('.dropdown-content')
      .slideToggle(450)
  })


function myFunction() {
  document.getElementById('myDropdown')
    .classList
    .toggle('show')
}

window.onclick = function (event) {
  if (!event.target.matches('.newCommand')) {
    var dropdowns = document.getElementsByClassName('dropdown-content')
    var i
    for (i = 0; i < dropdowns.length; i++) {
      var openDropdown = dropdowns[i]
      if (openDropdown.classList.contains('show')) {

      }
    }
  }
}

$(document).ready(function () {
  $('#typePermission').on('change', function () {
    var demovalue = $(this).val();
      $("div.myDiv").hide();
      $("#time").val('0');
    $("#show" + demovalue).show();
  });
});


$(function () {
  $('#fromDate')
    .datepicker()
})

$(function () {
  $('#fromDate1')
    .datepicker()
})
$(function () {
  $('#toDate')
    .datepicker()
})


const hours = document.querySelector('.hours');
const minutes = document.querySelector('.minutes');
const seconds = document.querySelector('.seconds');

const month = document.querySelector('.month');
const day = document.querySelector('.day');
const year = document.querySelector('.year');

function setDate() {
  const now = new Date();
  const mm = now.getMonth();
  const dd = now.getDate();
  const yyyy = now.getFullYear();
  const secs = now.getSeconds();
  const mins = now.getMinutes();
  const hrs = now.getHours();
  const monthName = [
    'January','February','March','April',
    'May','June','July','August','September',
    'October','November','December'
  ];

//  if (hrs >24) {
//    hours.innerHTML = hrs - 24;
//  } else {
//    hours.innerHTML = hrs;
//  }

//  if (secs < 10) {
//    seconds.innerHTML = '0' + secs;
//  } else {
//    seconds.innerHTML = secs;
//  }

//  if (mins < 10) {
//    minutes.innerHTML = '0' + mins;
//  } else {
//    minutes.innerHTML = mins;
//  }

//  month.innerHTML = monthName[mm];
//  day.innerHTML = dd;
//  year.innerHTML = yyyy;
//}

//setInterval(setDate,1000);
