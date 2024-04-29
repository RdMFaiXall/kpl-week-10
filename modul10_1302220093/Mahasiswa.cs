using System;

public class Mahasiswa
{
	// deklarasi atribut class Mahasiswa
	public string Name {  get; set; }
	public string Nim { get; set; }
	public List<string> Course { get; set; }
	public int Year { get; set; }

	// deklarasi constructor Mahasiswa untuk mengakses atribut
	public Mahasiswa(string Name, string Nim, List<string> Course, int Year)
	{
		this.Name = Name;
		this. Nim = Nim;
		this. Course = Course;
		this. Year = Year;
	}
}
