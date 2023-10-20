package com.example.gridlayout_v1

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val btn1 = findViewById<Button>(R.id.btn1)
        val btn2 = findViewById<Button>(R.id.btn2)
        val btn3 = findViewById<Button>(R.id.btn3)
        val btn4 = findViewById<Button>(R.id.btn4)
        val btn5 = findViewById<Button>(R.id.btn5)
        val btn6 = findViewById<Button>(R.id.btn6)
        val btn7 = findViewById<Button>(R.id.btn7)
        val btn8 = findViewById<Button>(R.id.btn8)
        val btn9 = findViewById<Button>(R.id.btn9)
        val buttons = arrayListOf<Button>(btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9)
        for ( b in buttons){
            b.setOnClickListener {
                Click(it as Button)
            }
        }
    }

    private fun Click(btn: Button){
        if(btn.text.toString()!="X"){
            btn.setText("X")
        }else{
            btn.setText("O")
        }
    }
}