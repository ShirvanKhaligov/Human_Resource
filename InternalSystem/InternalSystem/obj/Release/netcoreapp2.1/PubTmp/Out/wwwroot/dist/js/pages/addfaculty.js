$('.newCommand')
  .click(function () {
    $(this)
      .next('.dropdown-content')
      .slideToggle(450)
  })




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
