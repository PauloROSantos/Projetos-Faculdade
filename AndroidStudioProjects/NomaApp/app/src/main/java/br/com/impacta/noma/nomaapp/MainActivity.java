package br.com.impacta.noma.nomaapp;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;

public class MainActivity extends DebugActivity {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_main);

    }
    public void telaLogin(View view){
        setContentView(R.layout.login);
    }

    public void logar(View view){
        Intent it = new Intent(MainActivity.this,logado.class);

        ProgressBar loading = (ProgressBar) findViewById(R.id.progressBar_login);
        loading.setVisibility(view.VISIBLE);

        Button logar = (Button) findViewById(R.id.button_login);
        logar.setVisibility(view.INVISIBLE);

        EditText loginDado = (EditText) findViewById(R.id.login_dado);
        String login = loginDado.getText().toString();

        EditText senhaDado = (EditText) findViewById(R.id.senha_dado);
        String senha = senhaDado.getText().toString();

        startActivity(it);
    }

}
