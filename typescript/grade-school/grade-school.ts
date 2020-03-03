class GradeSchool{
    private school: Map<string, string[]>;

    constructor(){
        this.school = new Map<string, string[]>();
    }

    addStudent(studentName: string, grade: number): void{
        const tmpGrade = this.school.get(grade.toString()) || [];
        tmpGrade.push(studentName);
        this.school.set(grade.toString(), tmpGrade.sort());
    }

    studentRoster(): Map<string, string[]>{
        const roster = new Map<string, string[]>();
        for(const [grade, students] of this.school){
            roster.set(grade, Array.from(students));
        }
        return roster;
    }

    studentsInGrade(grade: number): string[]{
        return Array.from(this.school.get(grade.toString()) || []);
    }
}

export default GradeSchool