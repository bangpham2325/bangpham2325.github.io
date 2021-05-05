const button1 = document.getElementById("navIcon");
const menu = document.getElementsByClassName("header_Left");
const test1=document.getElementsByClassName("header_Right");
// console.log(button1);
// console.log("helo"+menu[0].classList);
// function myMenu2(){
//   if(test1. == "100%"){
//     menu[0].classList.add('header_Left2')
//   }else{
//     menu[0].classList.remove('header_Left2')
//   }
//   console.log("hello ban")
  
// }
// myMenu2();
function myMenu(){
  
    //menu.classList.remove('header_Left');
     menu[0].classList.toggle('header_Left2');
     
    // menu.toggle('header_Left');
    // menu.classList.toggle('header_Left1');
  };
  

  //document.querySelector("#contact-form").onsubmit=get_Submit;
  var typed = new Typed('.typed', {
    strings: ["Mobile Developer", "Web Developer","UI/UX Designer","Photographer"],
    typeSpeed: 30,
    backSpeed:30,
    loop:true,
    resetCallback: function () {
      newTyped();
  }
  });
  var typed1 = new Typed('.typed3', {
    strings: ["Mobile Developer", "Web Developer","UI/UX Designer","Photographer"],
    typeSpeed: 30,
    backSpeed:30,
    loop:true
  });
 
      