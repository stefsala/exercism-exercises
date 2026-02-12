int score(String word){
  int score = 0;
  List<String> points_table = ["AEIOULNRST","DG","BCMP","FHVWY","K","JX","QZ"];
  List<int> points = [1,2,3,4,5,8,10];
  for (var char in word.toUpperCase().split('')) {
    for(int i=0; i < points_table.length; i++) {
      if(points_table[i].contains(char)) 
        score += points[i];
    }
  }
  return score;
}