using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RodeSafetyTool.Models;

namespace RodeSafetyTool.Controllers
{
    public class RoadAccidentController : Controller
    {
        private readonly RoadAccidentDbContext _context;

        public RoadAccidentController(RoadAccidentDbContext context)
        {
            _context = context;
        }

        // GET: RoadAccident
        public async Task<IActionResult> Index()
        {
              return View(await _context.RoadAccidents.ToListAsync());
        }

        // GET: RoadAccident/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.RoadAccidents == null)
            {
                return NotFound();
            }

            var roadAccident = await _context.RoadAccidents
                .FirstOrDefaultAsync(m => m.ID == id);
            if (roadAccident == null)
            {
                return NotFound();
            }

            return View(roadAccident);
        }

        // GET: RoadAccident/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoadAccident/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Severity,Start_Time,End_Time,Start_Lat,Start_Lng,End_Lat,End_Lng,Distance,Description,Number,Street,Side,City,County,State,Zipcode,Country,Timezone,Airport_Code,Weather_Timestamp,Temperature,Wind_Chill,Humidity,Pressure,Visibility,Wind_Direction,Wind_Speed,Precipitation,Weather_Condition,Amenity,Bump,Crossing,Give_Way,Junction,No_Exit,Railway,Roundabout,Station,Stop,Traffic_Calming,Traffic_Signal,Turning_Loop,Sunrise_Sunset,Civil_Twilight,Nautical_Twilight,Astronomical_Twilight")] RoadAccident roadAccident)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roadAccident);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roadAccident);
        }

        // GET: RoadAccident/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.RoadAccidents == null)
            {
                return NotFound();
            }

            var roadAccident = await _context.RoadAccidents.FindAsync(id);
            if (roadAccident == null)
            {
                return NotFound();
            }
            return View(roadAccident);
        }

        // POST: RoadAccident/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Severity,Start_Time,End_Time,Start_Lat,Start_Lng,End_Lat,End_Lng,Distance,Description,Number,Street,Side,City,County,State,Zipcode,Country,Timezone,Airport_Code,Weather_Timestamp,Temperature,Wind_Chill,Humidity,Pressure,Visibility,Wind_Direction,Wind_Speed,Precipitation,Weather_Condition,Amenity,Bump,Crossing,Give_Way,Junction,No_Exit,Railway,Roundabout,Station,Stop,Traffic_Calming,Traffic_Signal,Turning_Loop,Sunrise_Sunset,Civil_Twilight,Nautical_Twilight,Astronomical_Twilight")] RoadAccident roadAccident)
        {
            if (id != roadAccident.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roadAccident);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoadAccidentExists(roadAccident.ID))
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
            return View(roadAccident);
        }

        // GET: RoadAccident/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.RoadAccidents == null)
            {
                return NotFound();
            }

            var roadAccident = await _context.RoadAccidents
                .FirstOrDefaultAsync(m => m.ID == id);
            if (roadAccident == null)
            {
                return NotFound();
            }

            return View(roadAccident);
        }

        // POST: RoadAccident/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.RoadAccidents == null)
            {
                return Problem("Entity set 'RoadAccidentDbContext.RoadAccidents'  is null.");
            }
            var roadAccident = await _context.RoadAccidents.FindAsync(id);
            if (roadAccident != null)
            {
                _context.RoadAccidents.Remove(roadAccident);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoadAccidentExists(int id)
        {
          return _context.RoadAccidents.Any(e => e.ID == id);
        }
    }
}
