let numeroAleatorio = generarNumeroAleatorio();
let intentosRestantes = 10;
let record;

const inputNumero = document.getElementById('numero');
const botonComprobar = document.getElementById('comprobar');
const mensaje = document.getElementById('mensaje');
const intentosRestantesSpan = document.getElementById('intentosRestantes');
const recordSpan = document.getElementById('record');
const botonReiniciar = document.getElementById('reiniciar');
const listaIntentos = document.getElementById('intentos');
const numerosIntentados = new Set();

function iniciarJuego() {
    intentosRestantes = 10;
    intentosRestantesSpan.textContent = intentosRestantes;
    numeroAleatorio = generarNumeroAleatorio();
    listaIntentos.innerHTML = '';
    mensaje.textContent = '';
    inputNumero.disabled = false;
    botonComprobar.disabled = false;
    inputNumero.value = '';
    record = parseInt(localStorage.getItem('record')) || 0;
    recordSpan.textContent = record;
}

function generarNumeroAleatorio() {
    return Math.floor(Math.random() * 99) + 1;
}

botonComprobar.addEventListener('click', function() {
    const numeroUsuario = parseInt(inputNumero.value);
    
    if (numerosIntentados.has(numeroUsuario)) {
        mensaje.textContent = 'Ya intentaste este número. Elige uno diferente.';
    } else if (isNaN(numeroUsuario) || numeroUsuario < 1 || numeroUsuario > 99) {
        mensaje.textContent = 'Por favor, ingresa un número válido entre 1 y 99.';
    } else {
        // Agregar el número a la lista de números intentados
        numerosIntentados.add(numeroUsuario);
        intentosRestantes--;
        intentosRestantesSpan.textContent = intentosRestantes;

        const itemIntento = document.createElement('dt');
        itemIntento.textContent = numeroUsuario;
        
        if (numeroUsuario < numeroAleatorio) {
            mensaje.textContent = 'El número es más alto.';
            itemIntento.innerHTML += ' <span class="flechaverde">↑</span>';
        } else if (numeroUsuario > numeroAleatorio) {
            mensaje.textContent = 'El número es más bajo.';
            itemIntento.innerHTML += ' <span class="flecharoja"">↓</span>';
        } else {
            mensaje.textContent = `¡FELICITACIONES CRACK GANASTE! Adivinaste el número ${numeroAleatorio}.`;
            if (intentosRestantes > localStorage.getItem('record')) {
                record = intentosRestantes;
                localStorage.setItem('record', record);
                recordSpan.textContent = record;
            }
            deshabilitarEntrada();
        }

        listaIntentos.appendChild(itemIntento);

        if (intentosRestantes === 0 && numeroUsuario !== numeroAleatorio) {
            mensaje.textContent = `¡PERDISTE, NO HAY NADIE PEOR QUE VOS! El número era ${numeroAleatorio}.`;
            deshabilitarEntrada();
        }
    }
    
    inputNumero.value = '';
});

function deshabilitarEntrada() {
    inputNumero.disabled = true;
    botonComprobar.disabled = true;
}

botonReiniciar.addEventListener('click', function() {
    intentosRestantes = 10;
    intentosRestantesSpan.textContent = intentosRestantes;
    numeroAleatorio = generarNumeroAleatorio();
    listaIntentos.innerHTML = '';
    mensaje.textContent = '';
    inputNumero.disabled = false;
    botonComprobar.disabled = false;
    inputNumero.value = '';


});

window.addEventListener('load', function() {
    iniciarJuego();
});


