
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nttd2410900020_exam.Models;

public class NttdStudentsController : Controller
{
    private readonly Nttd2410900020ExamDpContext _context;

    public NttdStudentsController(Nttd2410900020ExamDpContext context)
    {
        _context = context;
    }

    // GET: NTTDSTUDENTS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.NttdStudents.ToListAsync());
    }

    // GET: NTTDSTUDENTS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nttdstudent = await _context.NttdStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nttdstudent == null)
        {
            return NotFound();
        }

        return View(nttdstudent);
    }

    // GET: NTTDSTUDENTS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: NTTDSTUDENTS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,NttdName,NttdGender,NttdBirthDay,NttdEmail,NttdPhone,NttdActive")] NttdStudent nttdstudent)
    {
        if (ModelState.IsValid)
        {
            _context.Add(nttdstudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(nttdstudent);
    }

    // GET: NTTDSTUDENTS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nttdstudent = await _context.NttdStudents.FindAsync(id);
        if (nttdstudent == null)
        {
            return NotFound();
        }
        return View(nttdstudent);
    }

    // POST: NTTDSTUDENTS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,NttdName,NttdGender,NttdBirthDay,NttdEmail,NttdPhone,NttdActive")] NttdStudent nttdstudent)
    {
        if (id != nttdstudent.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(nttdstudent);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NttdStudentExists(nttdstudent.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(nttdstudent);
    }

    // GET: NTTDSTUDENTS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var nttdstudent = await _context.NttdStudents
            .FirstOrDefaultAsync(m => m.Id == id);
        if (nttdstudent == null)
        {
            return NotFound();
        }

        return View(nttdstudent);
    }

    // POST: NTTDSTUDENTS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var nttdstudent = await _context.NttdStudents.FindAsync(id);
        if (nttdstudent != null)
        {
            _context.NttdStudents.Remove(nttdstudent);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool NttdStudentExists(int? id)
    {
        return _context.NttdStudents.Any(e => e.Id == id);
    }
}
