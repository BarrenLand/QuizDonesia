using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintDisplay : MonoBehaviour
{
    public int randNum;
    public GameObject hintDisp;

    void Start()
    {
        
        StartCoroutine(HintTracker());
    }

    IEnumerator HintTracker()
    {
        randNum = Random.Range(1,10);
        if (randNum == 1)
        {
            hintDisp.GetComponent<Text>().text = "Proklamasi Kemerdekaan Indonesia dilaksanakan pada hari Jumat, 17 Agustus 1945 tahun Masehi, atau tanggal 17 Agustus 2605 menurut tahun Jepang, yang dibacakan oleh Soekarno dengan didampingi oleh Mohammad Hatta di sebuah rumah hibah dari Faradj Martak di Jalan Pegangsaan Timur No. 56, Jakarta Pusat.";
        }
        if (randNum == 2)
        {
            hintDisp.GetComponent<Text>().text = "Bendera Negara Indonesia yang secara singkat disebut bendera negara adalah Sang Merah Putih. Sang Saka Merah Putih, Merah Putih, atau kadang disebut Sang Dwiwarna (dua warna).";
        }
        if (randNum == 3)
        {
            hintDisp.GetComponent<Text>().text = "Bendera Negara Sang Merah Putih berbentuk empat persegi panjang dengan ukuran lebar 2/3 (dua-pertiga) dari panjang serta bagian atas berwarna merah dan bagian bawah berwarna putih yang kedua bagiannya berukuran sama.";
        }
        if (randNum == 4)
        {
            hintDisp.GetComponent<Text>().text = "Warna merah-putih bendera negara diambil dari warna panji atau pataka Kerajaan Majapahit yang berpusat di Jawa Timur pada abad ke-13.";
        }
        if (randNum == 5)
        {
            hintDisp.GetComponent<Text>().text = "Tidak hanya kerajaan Majapahit saja yang memakai bendera merah putih sebagai lambang kebesaran. Sebelum Majapahit, kerajaan Kediri telah memakai panji-panji merah putih. Selain itu, bendera perang Sisingamangaraja IX dari tanah Batak pun memakai warna merah putih sebagai warna benderanya, bergambar pedang kembar warna putih dengan dasar merah menyala dan putih.";
        }
        if (randNum == 6)
        {
            hintDisp.GetComponent<Text>().text = "Bendera Indonesia memiliki makna filosofis. Merah berarti keberanian, sedangkan putih berarti kesucian.";
        }
        if (randNum == 7)
        {
            hintDisp.GetComponent<Text>().text = "Bendera Indonesia memeiliki arti warna merah pun dikatakan melambangkan tubuh manusia, sedangkan putih melambangkan jiwa manusia. ";
        }
        if (randNum == 8)
        {
            hintDisp.GetComponent<Text>().text = "Bendera Negara wajib dikibarkan pada setiap peringatan Hari Kemerdekaan Bangsa Indonesia pada tanggal 17 Agustus oleh warga negara yang menguasai hak penggunaan rumah, gedung atau kantor, satuan pendidikan, transportasi umum, dan transportasi pribadi di seluruh wilayah Negara Kesatuan Republik Indonesia dan di kantor perwakilan Republik Indonesia di luar negeri.";
        }
        if (randNum == 9)
        {
            hintDisp.GetComponent<Text>().text = "Bendera Negara yang dikibarkan pada Proklamasi Kemerdekaan Bangsa Indonesia tanggal 17 Agustus 1945 di Jalan Pegangsaan Timur Nomor 56 Jakarta disebut Bendera Pusaka Sang Saka Merah Putih.";
        }
        if (randNum == 10)
        {
            hintDisp.GetComponent<Text>().text = "Bendera setengah tiang digunakan sebagai tanda berkabung apabila Presiden atau Wakil Presiden, mantan Presiden atau mantan Wakil Presiden, pimpinan atau anggota lembaga negara, menteri atau pejabat setingkat menteri, kepala daerah, dan/atau pimpinan dewan perwakilan rakyat daerah meninggal dunia.";
        }
        yield return new WaitForSeconds(10);
    }
}