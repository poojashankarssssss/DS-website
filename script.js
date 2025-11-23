document.getElementById('menu-toggle')?.addEventListener('click', function(){
  const nav = document.querySelector('.main-nav');
  nav.style.display = (nav.style.display === 'block') ? 'none' : 'block';
});
