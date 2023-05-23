// import 'dart:io';
void main() {
//input

  // print("Hello in Dart Enter Your Name");
  // String name;
  // name = stdin.readLineSync()!;
  // print('hello $name');
  // int num1 = 45;
  // int num2 = 45;
  // double res = num1 / num2;
  // print('$res');

//controles

  // print("Enter Number");
  // int num = int.parse(stdin.readLineSync()!);
  // if(num>100)
  // {
  //     print("Number is >100");

  // }else if(num<100){
  // print("Number <100");

  // }else
  // {
  // print("Number=100");
  // }
  //List
  // List<String> Students = ["Rehab", "Zaki", "Fayrouzaaa"];
  // print(Students);

  // //Set==>Store Unique Valyes
  // Set<String> Names = {'Rehab', 'Noor', 'Noor'};

  // List<String> NamesList = Names.toList();

  // print(NamesList);

  // //Map <Key,Value>
  // Map<int, String> StudentMap = {1: "Rehab", 2: "Zaki", 3: "Nasr"};
  // print(StudentMap[3]);

//foreach loop
  // List<String> Students = ["Rehab", "Zaki", "Fayrouzaaa"];
  // Students.forEach((element) {
  //   print(element);
  // });

  // print("================");
  // for (var name in Students) {
  //   print(name);
  // }

  //Task for Day 1
  Map<int, String> Names = {123: "Rehab", 456: "Zaki", 789: "Mohamed"};
  MapLoop(Names, printKeyValue);
  print("==========Search=============");
  SearchKey(Names, 123);
  print("==========Search=============");
  SearchKey(Names, 452);

}

void printKeyValue(dynamic key, dynamic value) {
  print('ID: $key, Name: $value');
}

void MapLoop(
    Map<dynamic, dynamic> map, void Function(dynamic, dynamic) callback) {
  map.forEach((key, value) {
    callback(key, value);
  });
}

void SearchKey(Map<dynamic, dynamic> map, dynamic key) {
    if (map.containsKey(key)) {
      dynamic value = map[key];
      print("Your Map Contains This Key");
      print("ID : $key, Name: $value");
    } else {
      print("Sorry This Key Not In Map");
    }
}
