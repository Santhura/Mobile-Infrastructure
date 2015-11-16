package infrasecur.qrreader;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Toast;

import com.google.zxing.integration.android.IntentIntegrator;
import com.google.zxing.integration.android.IntentResult;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        super.onActivityResult(requestCode, resultCode, data);
        if (requestCode == 0) {
            if (resultCode == RESULT_OK) {
                //Get result and go to the scanned site url
                String url = data.getStringExtra("SCAN_RESULT");

                Uri uri = Uri.parse(url);

                Intent intent = new Intent(Intent.ACTION_VIEW, uri);
                startActivity(intent);
            } else if (resultCode == RESULT_CANCELED) {
                //No result
                Toast.makeText(this, "There is no result", Toast.LENGTH_LONG);
            }
        }
    }

    public void btnScanQR(View view) {
        //Start scanner and save result in intent
        Intent intent = new Intent("com.google.zxing.client.android.SCAN");
        intent.putExtra("SCAN_MODE", "QR_CODE_MODE");//for Qr code, its "QR_CODE_MODE" instead of "PRODUCT_MODE"

        //Don´t save barcode in barcode scanner app
        intent.putExtra("SAVE_HISTORY", false);

        //Start intent
        startActivityForResult(intent, 0);
    }
}
