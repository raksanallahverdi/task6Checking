int[] numbers={-30,10,0,20,60,-5,30,40,50};

// 1.print etmek
// for (int i=0;i<numbers.Length;i++){
//     Console.WriteLine(numbers[i]);
// }

// 2.cemini tapmaq
// int sum=0;
// for (int i=0;i<numbers.Length-1;i++){
//     sum+=numbers[i];
// }
// Console.WriteLine(sum);

// 3.tersine print etmek
//  for (int i=numbers.Length-1;i>=0;i--){
//      Console.WriteLine(numbers[i]);
// }

// 4.ters cevirmek
// int left=0;
// int right=numbers.Length-1;

// while (left<numbers.Length/2){
//     int left2=numbers[left];
//     numbers[left]=numbers[right];
//     numbers[right]=left2;
//     left++;
//     left2++;
//     right--;
// }
// for (int i=0;i<numbers.Length;i++){
//     Console.WriteLine(numbers[i]);
// }

// 5. en boyuk element
// int max=numbers[0];
// for (int i=1;i<numbers.Length;i++){
//     if (numbers[i]>max){
//         max=numbers[i];
//     }
// }
// Console.WriteLine(max);

// 6.ededlerin sayini tapmaq
// int count=0;
// for (int i=0;i<numbers.Length;i++){
//     count++;
// }
// Console.WriteLine(count);

// 7.ededi sort etmek
// int find=30;
// for (int i=0;i<numbers.Length;i++){
//     if (numbers[i]==find){
//         Console.WriteLine(i);
//     }
// }

// 8. 0 ededinin sayini tapmaq
// int count=0;
// for (int i=0;i<numbers.Length;i++){
//     if (numbers[i]==0){
//     count++;
//     }
// }
// Console.WriteLine(count);

// 9.menfilerin sayini tapmaq
// int count=0;
// for (int i=0;i<numbers.Length;i++){
//     if (numbers[i]<0){
//     count++;
//     }
// }
// Console.WriteLine(count);

// 10.musbetlerin cemi
// int sum=0;
// for (int i=0;i<numbers.Length;i++){
//     if (numbers[i]>0){
//     sum+=numbers[i];
//     }
// }
// Console.WriteLine(sum);

// 11.arraydaki ededlerin kvadratini qaytarmaq
// for (int i=0;i<numbers.Length;i++){
//     numbers[i]=numbers[i]*numbers[i];
//     Console.WriteLine(numbers[i]);
// }

// 12.azalan sira ile sort etmek
// for (int _=0;_<numbers.Length-1;_++){
// for (int i=0;i<numbers.Length-1;i++){
// if (numbers[i+1]>numbers[i]){
//     int temp=numbers[i];
//     numbers[i]=numbers[i+1];
//     numbers[i+1]=temp;
// } 
// }
// }
// for (int i=0;i<numbers.Length;i++){
//     Console.WriteLine(numbers[i]);
// }






















