#include<stdio.h>
#include<stdlib.h>
#include<conio.h>


struct Student{
	int IDs;
	char name[50];
	char gender[50];
	int age;
	int rate;
	float math,chemistry,physics;
	float avg;
	float highest, lowest;
    char nationality[10];
};

typedef Student ST;
void InputStudent(ST &st);
void OutputStudent(ST st);
void InputStudentList(ST a[], int &n);
void OutputStudentList(ST a[], int n);
void SortStudent(ST a[], int n);
float FindHighestScore(ST a[], int n);
float FindLowestScore(ST a[], int n);


int main(){
	int n;
	
    do{
    	printf("\n Enter the number of student: \n");
    	scanf("%d", &n);
	}while (n<=0);
	
	ST a[n];
	
	
	while (true){

        printf("\n    ---STUDENT MANAGEMENT PROGRAM---   \n");
		printf("-----------------------------------------\n");
		printf("| 1.Input Student List 	                |\n");
		printf("| 2.Output Sudent List                  |\n");
		printf("| 3.Sort of student by average scores   |\n");
		printf("| 4.Find highest score                  |\n");
        printf("| 5.Find lowest score                   |\n");
		printf("| 0.Exit program                        |\n");
		printf("-----------------------------------------\n");
		printf("\n      ---ENTER YOUR SELECTION---       \n");
	
	
	int op;
	scanf("%d", &op);
	switch(op){
		case 1: 
		    printf("\n You have selected: Input Student List \n");
		    InputStudentList(a, n);
		    printf("\n Press any key to continue \n");
		    getch();
		    break;
		    
		case 2:
		    printf("\n You have selected: Output Student List \n");
		    OutputStudentList(a, n);
		    printf("\n Press any key to continue \n");
		    getch();
		    break;
		    
		case 3:
		    printf("\n You have selected: Sort of student by average scores \n");
		    SortStudent(a,n);
		    printf("\n Press any key to continue \n");
		    getch();
		    break;
		    
		case 4:
			printf("\n Highest score = %.2f", FindHighestScore (a,n));
			printf("\n Press any key to continue \n");
		    getch();
		    break;
		    
		case 5:
			printf("\n Lowest score = %.2f", FindLowestScore (a,n));
			printf("\n Press any key to continue \n");
		    getch();  
		    break;
		
		case 0:
			printf("\n You have selected: Exit program \n");
			exit(0);
			break;
		default:
			break;
			
			
	}
		
	}
	return 0;
}

// p = &st
// *p = st

void InputStudent(ST &st){
	printf("\n IDs: ");
	scanf("%d", &st.IDs);
	printf("\n Name: ");
	fflush(stdin);
	gets(st.name);
	printf("\n Gender: ");
	fflush(stdin);
	gets(st.gender);
	printf("\n Age: ");
	scanf("%d", &st.age);
	printf("\n Nationality: ");
	fflush(stdin);
	gets(st.nationality);
	
		
	do{
	printf("\n Math scores = \n");
	scanf("%f", &st.math);
    
	printf("\n Chemistry scores = \n");
	scanf("%f", &st.chemistry);
   
	printf("\n Physics scores = \n");
	scanf("%f", &st.physics);
    }while(st.math < 0 || st.chemistry < 0 || st.physics < 0 || st.math > 10 || st.chemistry >10 || st.physics >10);
    

	st.avg= ( st.math + st.chemistry + st.physics ) / 3;
	
	printf("\n Avg = %.2f", st.avg);
	
	printf("\n Rate: %s", st.rate);
	if (st.avg < 6.5){
		printf("\n Average \n");
	}else if (st.avg < 8 && st.avg >= 6.5){
		printf("\n Good \n");
	}else{
		printf("\n Excellent \n");
	}
}

float FindHighestScore(ST a[], int n){
    float highest = a[1].avg;
	for(int i = 0; i<n; i++){
		if(highest < a[i].avg){
			highest = a[i].avg;
		}
	}
	return highest;
}
float FindLowestScore(ST a[], int n){
	float lowest = a[1].avg;
	for(int i = 0; i<n; i++){
		if(lowest > a[i].avg){
			lowest = a[i].avg;
		}
	}
	return lowest;
}
	
	




void OutputStudent(ST st){
	printf("\n IDs: %d", st.IDs);
	printf("\n Name: %s", st.name);
	printf("\n Gender: %s", st.gender);
	printf("\n Age: %d", st.age);
	printf("\n Nationality: %s", st.nationality);
	printf("\n Math scores = %.2f", st.math);
	printf("\n Chemistry scores = %.2f", st.chemistry);
	printf("\n Physics scores = %.2f", st.physics);
	printf("\n Avg = %.2f", st.avg);
	printf("\n Rate student: %s", st.rate);
	if (st.avg < 6.5){
		printf("\n Average \n");
	}else if (st.avg < 8){
		printf("\n Good \n");
	}else{
		printf("\n Excellent \n");
	}
}
	
void InputStudentList(ST a[], int &n){
	printf("\n ---------- \n");
	for(int i=0; i<n ; i++){
		printf("\n Input student %d: ", i+1);
		InputStudent(a[i]);
		printf("\n ---------- \n");
	}
}

void OutputStudentList(ST a[], int n){
	printf("\n ---------- \n");
	for(int i=0; i<n ; i++){
		printf("\n Student information %d ", i+1);
		OutputStudent(a[i]);
    	printf("\n ---------- \n");	
		}
}

void SortStudent(ST a[], int n){
	
	Student st;
	int i,j;
    for (i=j+1; i<n; i++)
    for (j=0; j<n; j++)
    if (a[i].avg > a[j].avg){
		st=a[i];
		a[i]=a[j];
		a[j]=st;
	}
	OutputStudentList(a,n);

}
	
