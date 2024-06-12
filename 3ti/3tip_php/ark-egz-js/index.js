const btns = document.querySelectorAll('button');
const forms = document.querySelectorAll('.form');
showOnly(forms[0]);
btns.forEach((btn) => {
    btn.addEventListener('click', (e) => {
        switch (e.target.id) {
            case 'btn1':
                showOnly(forms[0]);
                break;
            case 'btn2':
                showOnly(forms[1]);
                break;
            case 'btn3':
                showOnly(forms[2]);
                break;
            case 'btn4':
                showOnly(forms[3]);
                break;

        }
    });
});
function showOnly(elem) {
    forms.forEach((form) => {
        form.style.display = 'none';
    });
    elem.style.display = 'block';
}