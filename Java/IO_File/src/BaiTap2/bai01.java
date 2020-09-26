package BaiTap2;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class bai01 {
	public static void main(String[] args) {
		 // Step 1 - File
        File file = new File("F:\\JAVA\\IO_File\\src\\BaiTap2\\data.txt");
        FileReader fr = null;
        BufferedReader br = null;
        try {
            // Step 2: Make a file reader
            fr = new FileReader(file);
            
            // Step 3: Make a buffer to read data
            br = new BufferedReader(fr);
            
            // Step 4: Read data from buffer to variable
            String data;
            // First line: row - column
            data = br.readLine();
            String[] datas = data.split(" ");
            if (datas.length != 2){
                System.out.println("Error: format data incorrect!");
                return;
            }
            int row = 0;
            int col = 0;
            try{
                row = Integer.parseInt(datas[0].trim());
                col = Integer.parseInt(datas[1].trim());
            }catch (NumberFormatException e){
                System.out.println("Error: number format incorrect!");
                return;
            }
            if (row <=0 || col <= 0){
                System.out.println("Error: row or column is not validate!");
                return;
            }
            // Read matrix data
            int[][] matrix = new int[row][col];
            int i = 0;
            while ((data = br.readLine())!= null){
                datas = data.split(" ");
                if (datas.length != col){
                    System.out.println("Error: format data incorrect!");
                    return;
                }
                try{
                    for (int j = 0; j<datas.length; j++) {
                        int int_value = Integer.parseInt(datas[j].trim());
                        matrix[i][j] = int_value;
                    }
                }catch (NumberFormatException e){
                    System.out.println("Error: number format incorrect!");
                    return;
                }
                i++;
            }
            if (i!=row){
                System.out.println("Error: format data incorrect!");
                return;
            }
            
            // Show matrix:
            for (int[] is : matrix) {
                for (int j : is) {
                    System.out.print(j + " ");
                }
                System.out.println();
            }
            
            // Cau 2:
            
        } catch (FileNotFoundException e) {
            e.printStackTrace();
        } catch (IOException e){
            e.printStackTrace();
        } finally{
            // Step 6: Close all connections
            try {
                br.close();
                fr.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
	}
}
