class AtbashCipher {
  String encode(String input) {
    input = input.toLowerCase().replaceAll(RegExp('[^a-zA-Z0-9]'),'');
    String encoded = '';
    const key = "zyxwvutsrqponmlkjihgfedcba";
    for(var i = 0; i < input.length; i++){
      if(key.contains(input.split('')[i])){
        encoded += key.split('')[25-key.split('').indexWhere((carattere) => carattere == input.split('')[i])];
      }
      else {
         encoded += input.split('')[i];
      } 
      if((i+1) % 5 == 0 && (i+1) != input.length)
        encoded += ' ';
    }
    return encoded;
  }

  String decode(String input) {
    String decoded = '';
    input = input.toLowerCase().replaceAll(RegExp('[^a-zA-Z0-9]'),'');
    const key = 'abcdefghijklmnopqrstuvwxyz';
    for(var i = 0; i < input.length; i++){
      if(key.contains(input.split('')[i])){
        decoded += key.split('')[25-key.split('').indexWhere((carattere) => carattere == input.split('')[i])];
      }
      else {
         decoded += input.split('')[i];
      }
    }
    return decoded;
  }
}

