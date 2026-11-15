using Microsoft.EntityFrameworkCore;
using Se3.EFC.Models;

namespace Se3.EFC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ass3
            //using var context = new AppDbContext();

            //context.Database.EnsureCreated();

            //if (!context.Students.Any())
            //{
            //    var students = new List<Student>
            //    {
            //        new Student { Id = 1, FullName = "Ahmed Ali", Email = "ahmed@example.com", DateOfBirth = new DateTime(2000, 5, 12) },
            //        new Student { Id = 2, FullName = "Sara Mohamed", Email = "sara@example.com", DateOfBirth = new DateTime(1998, 8, 22) },
            //        new Student { Id = 3, FullName = "Khaled Omar", Email = "khaled@example.com", DateOfBirth = new DateTime(2001, 2, 15) },
            //        new Student { Id = 4, FullName = "Mona Adel", Email = "mona@example.com", DateOfBirth = new DateTime(1999, 11, 3) },
            //        new Student { Id = 5, FullName = "Youssef Nabil", Email = "youssef@example.com", DateOfBirth = new DateTime(2002, 7, 25) }
            //    };

            //    context.Students.AddRange(students);
            //    context.SaveChanges();
            //}

            //if (!context.Enrollments.Any())
            //{
            //    var enrollments = new List<Enrollment>
            //    {
            //        new Enrollment { StudentId = 1, CourseId = 1, ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 95.5m },
            //        new Enrollment { StudentId = 1, CourseId = 2, ProgressPercentage = 45, Status = EnrollmentStatus.Active },
            //        new Enrollment { StudentId = 2, CourseId = 1, ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 88.0m },
            //        new Enrollment { StudentId = 2, CourseId = 3, ProgressPercentage = 20, Status = EnrollmentStatus.Active },
            //        new Enrollment { StudentId = 3, CourseId = 2, ProgressPercentage = 100, Status = EnrollmentStatus.Completed, FinalGrade = 92.0m },
            //        new Enrollment { StudentId = 4, CourseId = 5, ProgressPercentage = 10, Status = EnrollmentStatus.Active },
            //        new Enrollment { StudentId = 5, CourseId = 1, ProgressPercentage = 0, Status = EnrollmentStatus.Dropped },
            //        new Enrollment { StudentId = 5, CourseId = 3, ProgressPercentage = 60, Status = EnrollmentStatus.Active }
            //    };

            //    context.Enrollments.AddRange(enrollments);
            //    context.SaveChanges();
            //}

            //Console.WriteLine("Database and seeding initialized successfully!");



            //static void AddInstructor(AppDbContext context, string name, string email, string? bio)
            //{
            //    var instructor = new Instructor { FullName = name, Email = email, Bio = bio };
            //    context.Instructors.Add(instructor);
            //    context.SaveChanges();
            //    Console.WriteLine($"Added Instructor with Id: {instructor.Id}");
            //}

            //static void AddCourse(AppDbContext context, string title, decimal price, CourseLevel level, int instructorId, int categoryId)
            //{
            //    var instructorExists = context.Instructors.Any(i => i.Id == instructorId);
            //    var categoryExists = context.Categories.Any(c => c.Id == categoryId);

            //    if (!instructorExists || !categoryExists)
            //    {
            //        Console.WriteLine("Error: Instructor or Category does not exist.");
            //        return;
            //    }

            //    var course = new Course
            //    {
            //        Title = title,
            //        Price = price,
            //        Level = level,
            //        InstructorId = instructorId,
            //        CategoryId = categoryId,
            //        IsPublished = false
            //    };

            //    context.Courses.Add(course);
            //    context.SaveChanges();
            //    Console.WriteLine($"Added Course successfully with Id: {course.Id}");
            //}

            //static void AddStudents(AppDbContext context, List<Student> students)
            //{
            //    context.Students.AddRange(students);
            //    context.SaveChanges();
            //    foreach (var student in students)
            //    {
            //        Console.WriteLine($"Added Student: {student.FullName} with Id: {student.Id}");
            //    }
            //}

            //static void EnrollStudent(AppDbContext context, int studentId, int courseId)
            //{
            //    var student = context.Students.Find(studentId);
            //    var course = context.Courses.Find(courseId);

            //    if (student == null) { Console.WriteLine("Student not found."); return; }
            //    if (course == null) { Console.WriteLine("Course not found."); return; }
            //    if (!course.IsPublished) { Console.WriteLine("Enrollment refused: Course is not published."); return; }

            //    var alreadyEnrolled = context.Enrollments.Any(e => e.StudentId == studentId && e.CourseId == courseId);
            //    if (alreadyEnrolled) { Console.WriteLine("Student is already enrolled in this course."); return; }

            //    var enrollment = new Enrollment
            //    {
            //        StudentId = studentId,
            //        CourseId = courseId,
            //        ProgressPercentage = 0,
            //        Status = EnrollmentStatus.Active
            //    };

            //    context.Enrollments.Add(enrollment);
            //    context.SaveChanges();
            //    Console.WriteLine("Student enrolled successfully.");
            //}

            //static void FindCourse(AppDbContext context, int id, string title)
            //{
            //    var courseById = context.Courses.Find(id);
            //    Console.WriteLine(courseById != null ? $"Found by Id: {courseById.Title}" : "Course not found by Id.");

            //    var courseByTitle = context.Courses.FirstOrDefault(c => c.Title == title);
            //    Console.WriteLine(courseByTitle != null ? $"Found by Title: {courseByTitle.Title} - Price: {courseByTitle.Price}" : "Course not found by Title.");
            //}

            //static void FilterCourses(AppDbContext context, decimal minPrice, decimal maxPrice)
            //{
            //    var courses = context.Courses
            //        .Where(c => c.Price >= minPrice && c.Price <= maxPrice)
            //        .OrderByDescending(c => c.Price)
            //        .Select(c => new { c.Title, c.Level, c.Price })
            //        .ToList();

            //    foreach (var c in courses)
            //    {
            //        Console.WriteLine($"Title: {c.Title} | Level: {c.Level} | Price: {c.Price:C}");
            //    }
            //}

            //static void PrintSubCategories(AppDbContext context, int categoryId)
            //{
            //    var subCategories = context.Categories.Where(c => c.ParentCategoryId == categoryId).ToList();
            //    Console.WriteLine($"Sub-categories for Category {categoryId}:");
            //    foreach (var sc in subCategories)
            //    {
            //        Console.WriteLine($"- {sc.Name}");
            //    }

            //    var topLevel = context.Categories.Where(c => c.ParentCategoryId == null).ToList();
            //    Console.WriteLine("Top-level Categories:");
            //    foreach (var tl in topLevel)
            //    {
            //        Console.WriteLine($"- {tl.Name}");
            //    }
            //}

            //static void PrintCourseRoster(AppDbContext context, int courseId)
            //{
            //    var studentIds = context.Enrollments
            //        .Where(e => e.CourseId == courseId)
            //        .Select(e => e.StudentId)
            //        .ToList();

            //    Console.WriteLine($"Total students enrolled: {studentIds.Count}");

            //    var students = context.Students
            //        .Where(s => studentIds.Contains(s.Id))
            //        .Select(s => s.FullName)
            //        .ToList();

            //    foreach (var name in students)
            //    {
            //        Console.WriteLine($"- {name}");
            //    }
            //}

            //static void ChangeCoursePrice(AppDbContext context, int courseId, decimal newPrice)
            //{
            //    var course = context.Courses.Find(courseId);
            //    if (course != null)
            //    {
            //        course.Price = newPrice;
            //        context.SaveChanges();
            //        Console.WriteLine("Course price updated successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Course not found.");
            //    }
            //}

            //static void UpdateEnrollmentProgress(AppDbContext context, int studentId, int courseId, int progress)
            //{
            //    if (progress < 0 || progress > 100)
            //    {
            //        Console.WriteLine("Invalid progress value. Must be between 0 and 100.");
            //        return;
            //    }

            //    var enrollment = context.Enrollments.Find(studentId, courseId);
            //    if (enrollment == null)
            //    {
            //        Console.WriteLine("Enrollment not found.");
            //        return;
            //    }

            //    enrollment.ProgressPercentage = progress;
            //    if (progress == 100)
            //    {
            //        enrollment.Status = EnrollmentStatus.Completed;
            //    }

            //    context.SaveChanges();
            //    Console.WriteLine("Enrollment progress updated.");
            //}

            //static void PublishCourse(AppDbContext context, int courseId)
            //{
            //    var course = context.Courses.Find(courseId);
            //    if (course != null)
            //    {
            //        course.IsPublished = true;
            //        course.PublishedDate = DateTime.UtcNow;
            //        context.SaveChanges();
            //        Console.WriteLine("Course published successfully.");
            //    }
            //}

            //static void UnenrollStudent(AppDbContext context, int studentId, int courseId)
            //{
            //    var enrollment = context.Enrollments.Find(studentId, courseId);
            //    if (enrollment != null)
            //    {
            //        context.Enrollments.Remove(enrollment);
            //        context.SaveChanges();
            //        Console.WriteLine("Enrollment removed successfully.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Enrollment not found.");
            //    }
            //}

            //static void DeleteCategorySafe(AppDbContext context, int categoryId)
            //{
            //    try
            //    {
            //        var category = context.Categories.Find(categoryId);
            //        if (category != null)
            //        {
            //            context.Categories.Remove(category);
            //            context.SaveChanges();
            //        }
            //    }
            //    catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            //    {
            //        Console.WriteLine($"Caught expected exception: {ex.InnerException?.Message ?? ex.Message}");
            //    }

            //    bool hasSubCategories = context.Categories.Any(c => c.ParentCategoryId == categoryId);
            //    if (hasSubCategories)
            //    {
            //        Console.WriteLine("Cannot delete category because it still has sub-categories.");
            //    }
            //    else
            //    {
            //        var category = context.Categories.Find(categoryId);
            //        if (category != null)
            //        {
            //            context.Categories.Remove(category);
            //            context.SaveChanges();
            //            Console.WriteLine("Category deleted successfully.");
            //        }
            //    }
            //}

            //static void DeleteCourse(AppDbContext context, int courseId)
            //{
            //    var course = context.Courses.Include(c => c.Enrollments).FirstOrDefault(c => c.Id == courseId);
            //    if (course == null) return;

            //    Console.WriteLine($"Enrollments count before delete: {course.Enrollments.Count}");
            //    context.Courses.Remove(course);
            //    context.SaveChanges();
            //    Console.WriteLine("Course and its dependent enrollments removed.");
            //}

            //static void BulkPriceRaise(AppDbContext context, CourseLevel level, decimal percentage)
            //{
            //    int affectedRows = context.Courses
            //        .Where(c => c.Level == level && c.IsPublished)
            //        .ExecuteUpdate(s => s.SetProperty(c => c.Price, c => c.Price * (1 + percentage / 100)));

            //    Console.WriteLine($"Bulk price raise affected {affectedRows} courses.");
            //}

            //static void BulkDeleteDroppedEnrollments(AppDbContext context)
            //{
            //    int affectedRows = context.Enrollments
            //        .Where(e => e.Status == EnrollmentStatus.Dropped)
            //        .ExecuteDelete();

            //    Console.WriteLine($"Bulk delete affected {affectedRows} enrollments.");
            //} 
            #endregion

        }
    }
}
