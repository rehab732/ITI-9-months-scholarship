import 'package:flutter/material.dart';

void main() {
  runApp(MyWidget());
}


class MyWidget extends StatelessWidget {
  MyWidget();

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        body: Column(
          children: [
            Expanded(
              child: Align(
                alignment: Alignment.center,
                child: Container(
                  color: Colors.red,
                  width: 150,
                  height: 100,
                  child: const Center(
                    child: Text(
                      "hello Mohamed",
                      style: TextStyle(
                        color: Colors.white,
                        fontSize: 20,
                        fontWeight: FontWeight.bold,
                      ),
                    ),
                  ),
                ),
              ),
            ),
            BottomNav(),
          ],
        ),
      ),
    );
  }
}

class BottomNav extends StatelessWidget {
  const BottomNav({Key? key});

  @override
  Widget build(BuildContext context) {
    return Row(
      children: [
        Expanded(
          child: Column(
            children: const [
              Text("hhhhhh"),
              Icon(Icons.settings),
            ],
          ),
        ),
        Expanded(
          child: Column(
            children: const [
              Text("hhhhhh"),
              Icon(Icons.settings),
            ],
          ),
        ),
        Expanded(
          child: Column(
            children: const [
              Text("hhhhhh"),
              Icon(Icons.settings),
            ],
          ),
        ),
      ],
    );
  }
}
class CustomNavigationBar extends StatefulWidget {
  @override
  _CustomNavigationBarState createState() => _CustomNavigationBarState();
}

class _CustomNavigationBarState extends State<CustomNavigationBar> {
  int _currentIndex = 0;

  @override
  Widget build(BuildContext context) {
    return BottomNavigationBar(
      currentIndex: _currentIndex,
      onTap: (index) {
        setState(() {
          _currentIndex = index;
        });
      },
      items: [
        BottomNavigationBarItem(
          icon: Icon(Icons.home),
          label: 'Home',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.person),
          label: 'Profile',
        ),
        BottomNavigationBarItem(
          icon: Icon(Icons.settings),
          label: 'Settings',
        ),
      ],
    );
  }
}
