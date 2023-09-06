#palabra = input("Palabra: ")
#if str(palabra) == str(palabra)[::-1]:
#    print("Es Palindromo")
#else:
#    print("No es Palindromo")

frase = input("Ingrese una frase: ")
palindromos = []

palabras = frase.split() # separar la frase en palabras
for palabra in palabras:
    palabra_inversa = palabra[::-1] # invertir la palabra
    if palabra == palabra_inversa: # comprobar si es palíndromo
        palindromos.append(palabra)

if len(palindromos) > 0:
    print("La frase contiene", len(palindromos), "palíndromos:", palindromos)
else:
    print("La frase no contiene palíndromos.")