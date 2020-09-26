package week_08;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Example_IO {

	public static void main(String[] args) {
		// Step 1: Make a mapping to file
		File file_in = new File("F:\\JAVA\\IO_File\\src\\week_08\\Example_3.txt");
		File file_out = new File("F:\\JAVA\\IO_File\\src\\week_08\\Example_3_out.txt");
		
		// Example - read data
		int sum = Example_IO.readData(file_in);
		
		// Example - write data
		Example_IO.writeData(file_out, sum);
		
		// Example - Anti-virus
		// Example_IO.checkVirus(file);
	}

	public static void writeData(File file, int sum) {
		FileWriter fw = null;
		BufferedWriter bw = null;
		try {
			// Step 2: Make a file writer
			fw = new FileWriter(file);
			
			// Step 3: Make a buffer to read data
			bw = new BufferedWriter(fw);
			
			// Step 4: Data process
			// N.A
			
			// Step 5: Write data to file via buffered writer
			bw.write("Ket qua cua chuong trinh la:");
			bw.write("" + sum);	
			bw.newLine();
			bw.write("END.");
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e){
			e.printStackTrace();
		} finally{
			// Step 6: Close all connections
			try {
				bw.close();
				fw.close();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

	public static int readData(File file) {
		FileReader fr = null;
		BufferedReader br = null;
		int sum = 0;
		try {
			// Step 2: Make a file reader
			fr = new FileReader(file);
			
			// Step 3: Make a buffer to read data
			br = new BufferedReader(fr);
			
			// Step 4: Read data from buffer to variable
			String data;
			while ((data = br.readLine())!= null){
				// Step 5: Data processing
				try{
					System.out.println(data);
					String[] datas = data.split(":");
					for (String d : datas) {
						int value = Integer.parseInt(d);
						sum += value;
					}
				}catch (NumberFormatException e){
					// N.A
				}
			}
			System.out.println(sum);
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
		return sum;
	}

	public static void checkVirus(File file) {
		if (file.isFile()){
			System.out.println(file.getAbsolutePath());
			// TODO - check virus in file
			System.out.println(file.length());
		}else{
			System.out.println(file.getAbsolutePath());
			File[] lfiles = file.listFiles();
			for (File f : lfiles) {
				Example_IO.checkVirus(f);
			}
		}
		try {
			Thread.sleep(10);
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
