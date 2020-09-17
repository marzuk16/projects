#include<iostream>
#include<fstream>
#include<iomanip>
#include<cstring>
using namespace std;

//      class used in project

class info{
public:
    int rollno;
    char name[50];
    double per;
    char grade;
    int e_marks,dld_marks,oop_marks,acct_marks,oopl_marks;

    void calculate();

};

//      inherit class

class student:public info{

public:
    void getdata(); //function accept data to user
    void showdata();    //function for show data on screen
    void show_tebular();    //function for show data in table
    int retrollno();

};

void info::calculate()
{
    per=(e_marks+dld_marks+oop_marks+acct_marks+oopl_marks)/5;

	if(per>=60)
		grade='A';
	else if(per>=50)
		grade='B';
	else if(per>=33)
		grade='C';
	else
		grade='F';

}

void student::getdata()
{
    cout<<"\nEnter the roll number of student: ";
    cin>>rollno;
    cout<<"\nEnter the name of student: ";
    cin.ignore();
	cin.getline(name,50);
    cout<<"\nEnter the marks in Electronics: ";
    cin>>e_marks;
    cout<<"\nEnter the marks in Digital logic design: ";
    cin>>dld_marks;
    cout<<"\nEnter the marks in Object oriented programming: ";
    cin>>oop_marks;
    cout<<"\nEnter the marks in Accounting: ";
    cin>>acct_marks;
    cout<<"\nEnter the marks in Object oriented programming lab: ";
    cin>>oopl_marks;
    calculate();
}

void student::showdata()
{
    cout<<"\nEnter the roll number of student: "<<rollno;
    cout<<"\nEnter the name of student: "<<name;
    cout<<"\nEnter the marks in Electronics: "<<e_marks;
    cout<<"\nEnter the marks in Digital logic design: "<<dld_marks;
    cout<<"\nEnter the marks in Object oriented programming: "<<oop_marks;
    cout<<"\nEnter the marks in Accounting: "<<acct_marks;
    cout<<"\nEnter the marks in Object oriented programming lab: "<<oopl_marks;
    cout<<"\nPercentage of student is: "<<per;
    cout<<"\nGrade of student is: "<<grade;
}

void student::show_tebular()
{
    cout<<rollno<<setw(6)<<" "<<name<<setw(10)<<e_marks<<setw(4)<<dld_marks<<setw(4)<<oop_marks<<setw(4)
    <<acct_marks<<setw(4)<<oopl_marks<<setw(6)<<per<<setw(6)<<grade<<endl;
}

int student::retrollno()
{
    return rollno;
}

//********************************************************
//              Function declaration
//********************************************************

void Save_Student();
void displa_yAll();
void Search_display(int);
void modify_Student(int);
void delete_Student(int);
void Display_Class_Result();
void Display_Result();


//********************************************************
//      function to write in file
//********************************************************

void write_student()
{
    student st;
    ofstream outfile;
    outfile.open("student.dat",ios::binary|ios::app);
    st.getdata();
    outfile.write(reinterpret_cast<char *> (&st), sizeof(student));
    outfile.close();

    cout<<"\n\nStudent record has been created.";

    cin.ignore();
    cin.get();
}

//********************************************************
//      function to read all records from file
//********************************************************

void display_all()
{
    student st;
    ifstream infile;
    infile.open("student.dat",ios::binary);
    if(!infile)
    {
        cout<<"File could not be open !!!!!! ";

        return;
    }

    cout<<"\n\n\n\tDisplay all records !!!!!! \n\n";
    while(infile.read(reinterpret_cast<char *> (&st), sizeof(student)))
    {
        st.showdata();
        cout<<"\n\n===================================\n";
    }
        infile.close();
        cin.ignore();
        cin.get();
}

//********************************************************
//      function to read specific records from file
//********************************************************

void display_sp(int n)
{
    student st;
    ifstream infile;
    infile.open("student.dat",ios::binary);

    if(!infile)
    {
        cout<<"File could not be open !!!!!! ";

        return ;
    }

    int flag=0;
    while(infile.read(reinterpret_cast<char *> (&st), sizeof(student)))
    {
        if(st.retrollno()==n)
        {
            st.showdata();
            flag=1;
        }
    }
    infile.close();
    if(flag==0)
        cout<<"\n\nrecord not exit";
        cin.ignore();
        cin.get();
}

//********************************************************
//      function to modify records of file
//********************************************************

void modify_student(int n)
{
    int found=0;
    student st;
    fstream file;
    file.open("student.dat",ios::binary|ios::in|ios::out);

    if(!file)
    {
        cout<<"File could not be open !!!!! ";
        cin.ignore();
        cin.get();
        return;
    }
    while(!file.eof() && found==0)
    //while(file.read((char *) &st, sizeof(student)) && found==0)
    {
        file.read(reinterpret_cast<char *> (&st), sizeof(student));
        if(st.retrollno()==n)
        {
            st.showdata();
            cout<<"\n\nPlease enter the new details of student"<<endl;
            st.getdata();
            int pos=(-1)*static_cast<int>(sizeof(st));
            file.seekp(pos,ios::cur);
            file.write(reinterpret_cast<char *> (&st), sizeof(student));
            cout<<"\n\n\t Record Updated";
            found=1;
        }
    }
    file.close();
    if(found==0)
    {
        cout<<"\n\n Record not found ";
    }
    cin.ignore();
    cin.get();
}

//********************************************************
//      function to delete records of file
//********************************************************

void delete_student(int n)
{
    student st;
    ifstream infile;
    infile.open("student.dat",ios::binary);
    if(!infile)
    {
        cout<<"File could not be open !!!!! ";
        cin.ignore();
        cin.get();

        return ;
    }
    ofstream outfile;
    outfile.open("temp.dat",ios::out);
    infile.seekg(0,ios::beg);
    while(infile.read(reinterpret_cast<char *> (&st), sizeof(student)))
    {
        if(st.retrollno()!=n)
        {
            outfile.write(reinterpret_cast<char *> (&st), sizeof(student));
        }
    }
    outfile.close();
    infile.close();
    remove("student.dat");
    rename("temp.dat","student.dat");
    cout<<"\n\n\tRecord Deleted......";
    cin.ignore();
    cin.get();
}

//********************************************************
//      function to modify records of file
//********************************************************

void class_result()
{
    student st;
    ifstream infile;
    infile.open("student.dat",ios::binary);
    if(!infile)
    {
        cout<<"File could not be open !!!!!!  ";
        cin.ignore();
        cin.get();
        return;
    }
    cout<<"\n\n\t\tALL STUDENTS RESULT \n\n";
    cout<<"=====================================================\n";
    cout<<"R.NO  NAME   EEE   DLD   OOP   ACCT   OOPL PER   AVG"<<endl;
    cout<<"=====================================================\n";

    while(infile.read(reinterpret_cast<char *> (&st), sizeof(student)))
    {
        st.show_tebular();
    }
    cin.ignore();
    cin.get();
    infile.close();
}

//********************************************************
//     Introduction function
//********************************************************

void intro()
{
    cout<<"\n\n\n\t\t Student";
    cout<<"\n\n\t\tReport Card";
    cout<<"\n\n\t\t  Project";
    cout<<"\n\n\n\tMade by : Md. Marzukul Islam";
    cout<<"\n\t\t ID : CSE 063 07497";
    cout<<"\n\n\tUniversity : Stamford University Bangladesh";

}

//********************************************************
//      The main function of program
//********************************************************

int main()
{
	char ch;
	int num;
	cout.setf(ios::fixed|ios::showpoint);
	cout<<setprecision(2);

	intro();

	do
	{

	cout<<"\n\n\n\t****************************************";
	cout<<"\n\n\t1.CREATE STUDENT RECORD";
	cout<<"\n\n\t2.DISPLAY ALL STUDENTS RECORDS";
	cout<<"\n\n\t3.SEARCH STUDENT RECORD ";
	cout<<"\n\n\t4.MODIFY STUDENT RECORD";
	cout<<"\n\n\t5.DELETE STUDENT RECORD";
	cout<<"\n\n\t6. DISPLAY CLASS RESULT";
	cout<<"\n\n\t7. EXIT";
	cout<<"\n\n\t************************************";
	cout<<"\n\n\tPlease Enter Your Choice (1-7): ";
	cin>>ch;

	switch(ch)
	{
	case '1':	write_student(); break;
	case '2':	display_all(); break;
	case '3':	cout<<"\n\n\tPlease Enter Student's roll number: "; cin>>num;
				display_sp(num); break;
	case '4':	cout<<"\n\n\tPlease Enter Student's roll number: "; cin>>num;
			modify_student(num);break;
	case '5':	cout<<"\n\n\tPlease Enter Student's roll number: "; cin>>num;
			delete_student(num);break;
	case '6' :	class_result(); break;

	default:	cout<<"\a";

    }
	}while(ch!='7');

	return 0;
}





