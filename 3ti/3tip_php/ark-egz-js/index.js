const btns = document.querySelectorAll('button');
const forms = document.querySelectorAll('.form');
const inputs = document.querySelectorAll('input[type=text]');
const progress = document.querySelector('.progress');
progress.style.width = '0%';
let current = 0;
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
inputs.forEach((input) => {
    input.addEventListener('focus', (e) => {
        if (current <= 75) {
            current += 25
            progress.style.width = `${current}%`;
            console.log(current);
            console.log(progress.style.width);
        }

    });
});
function showOnly(elem) {
    forms.forEach((form) => {
        form.style.display = 'none';
    });
    elem.style.display = 'block';
}