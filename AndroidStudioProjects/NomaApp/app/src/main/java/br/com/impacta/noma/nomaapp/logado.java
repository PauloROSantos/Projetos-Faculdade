package br.com.impacta.noma.nomaapp;

import android.support.v7.app.ActionBar;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

public class logado extends DebugActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        setContentView(R.layout.activity_logado);

        ActionBar actionBar = getSupportActionBar();
        actionBar.setTitle("Logado");

        Bundle bundle = getIntent().getExtras();
        if(bundle != null){
            String login = bundle.getString("login");
            String senha = bundle.getString("senha");

            TextView bemVindo = (TextView) findViewById(R.id.bemVindo);
            bemVindo.setText("Bem vindo "+login+" sua senha é "+senha);
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        if(id == R.id.action_agendar) {
            Toast.makeText(logado.this,"Agendar",Toast.LENGTH_SHORT).show();
        } else if (id == R.id.action_calendario) {
            Toast.makeText(logado.this,"Agendar",Toast.LENGTH_SHORT).show();
        } else if ( id == R.id.action_config) {
            Toast.makeText(logado.this,"Agendar",Toast.LENGTH_SHORT).show();
        } else if ( id == R.id.action_sair) {
            Toast.makeText(logado.this,"Agendar",Toast.LENGTH_SHORT).show();
        }
        return super.onOptionsItemSelected(item);
    }

}
