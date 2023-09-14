package com.example.cw2

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import java.lang.NumberFormatException

class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        val aInput = findViewById<EditText>(R.id.editTextNumberA)
        val bInput = findViewById<EditText>(R.id.editTextNumberB)
        val addButton = findViewById<Button>(R.id.buttonAdd)
        val tvResult = findViewById<TextView>(R.id.textViewResult)
        addButton.setOnClickListener {
            try {
                val a = aInput.text.toString().toDouble();
                val b = bInput.text.toString().toDouble();
                tvResult.text = "$a + $b = " + (a + b).toString()
            }catch (e:NumberFormatException){
                Toast.makeText(this@MainActivity,"Błędne dane",Toast.LENGTH_SHORT).show()
            }

        }
    }
}