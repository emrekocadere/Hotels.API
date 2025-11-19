import { Link } from 'react-router-dom';
import { useState } from 'react';

const Header = () => {
  const [isMenuOpen, setIsMenuOpen] = useState(false);
  const [isUserMenuOpen, setIsUserMenuOpen] = useState(false);
  
  const isAuthenticated = true; 
  const user = { firstName: 'Salih Emre', lastName: 'Kocadere' }; 

  return (
    <header className="sticky top-0 z-50 bg-slate-700/95 text-white shadow-lg backdrop-blur-sm">
      <div className="max-w-7xl mx-auto px-4 py-4">
        <div className="flex items-center justify-between">

          <Link to="/" className="flex items-center gap-2">
            <div className="w-10 h-10 bg-white text-slate-700 rounded-lg flex items-center justify-center font-bold shadow-md">
              <span>H</span>
            </div>
            <span className="text-xl font-bold">HotelBooking</span>
          </Link>

          <nav className="hidden md:flex items-center space-x-6">
            <Link to="/" className="text-slate-100 hover:text-white transition-colors font-medium">
              Home
            </Link>
            <Link to="/hotels" className="text-slate-100 hover:text-white transition-colors font-medium">
              Hotels
            </Link>
          </nav>

          <div className="hidden md:flex items-center gap-3">
            {isAuthenticated ? (
              <div className="relative">
                <button
                  onClick={() => setIsUserMenuOpen(!isUserMenuOpen)}
                  className="flex items-center gap-2 px-4 py-2 rounded-lg hover:bg-slate-600 transition-all"
                >
                  <div className="w-8 h-8 bg-blue-500 rounded-full flex items-center justify-center font-semibold text-sm">
                    {user.firstName[0]}{user.lastName[0]}
                  </div>
                  <span className="font-medium">{user.firstName} {user.lastName}</span>
                  <svg className={`w-4 h-4 transition-transform ${isUserMenuOpen ? 'rotate-180' : ''}`} fill="none" stroke="currentColor" viewBox="0 0 24 24">
                    <path strokeLinecap="round" strokeLinejoin="round" strokeWidth={2} d="M19 9l-7 7-7-7" />
                  </svg>
                </button>
                
                {isUserMenuOpen && (
                  <div className="absolute right-0 mt-2 w-48 bg-white rounded-lg shadow-lg py-2 z-50">
                    <Link
                      to="/wishlist"
                      className="block px-4 py-2 text-slate-700 hover:bg-slate-100 transition-colors"
                      onClick={() => setIsUserMenuOpen(false)}
                    >
                      Wishlist
                    </Link>
                    <Link
                      to="/reservations"
                      className="block px-4 py-2 text-slate-700 hover:bg-slate-100 transition-colors"
                      onClick={() => setIsUserMenuOpen(false)}
                    >
                      My Bookings
                    </Link>
                    <hr className="my-2" />
                    <button
                      className="block w-full text-left px-4 py-2 text-red-600 hover:bg-slate-100 transition-colors"
                      onClick={() => {
                        setIsUserMenuOpen(false);
          
                      }}
                    >
                      Logout
                    </button>
                  </div>
                )}
              </div>
            ) : (
              <>
                <Link to="/login" className="text-white hover:text-slate-200 font-medium px-4 py-2 rounded-lg hover:bg-slate-600 transition-all">
                  Sign In
                </Link>
                <Link to="/register" className="bg-blue-500 text-white px-5 py-2 rounded-lg font-medium hover:bg-blue-600 transition-all shadow-md hover:shadow-lg transform hover:scale-105">
                  Sign Up
                </Link>
              </>
            )}
          </div>

          <button
            onClick={() => setIsMenuOpen(!isMenuOpen)}
            className="md:hidden p-2 rounded-lg hover:bg-slate-600 transition-all"
            aria-label="Toggle menu"
          >
            <svg
              className="w-6 h-6 text-white"
              fill="none"
              strokeLinecap="round"
              strokeLinejoin="round"
              strokeWidth="2"
              viewBox="0 0 24 24"
              stroke="currentColor"
            >
              {isMenuOpen ? (
                <path d="M6 18L18 6M6 6l12 12" />
              ) : (
                <path d="M4 6h16M4 12h16M4 18h16" />
              )}
            </svg>
          </button>
        </div>

        {isMenuOpen && (
          <nav className="md:hidden py-4 border-t border-slate-600">
            <div className="flex flex-col space-y-4">
              <Link
                to="/"
                className="text-slate-200 hover:text-white transition-colors font-semibold"
                onClick={() => setIsMenuOpen(false)}
              >
                Home
              </Link>
              <Link
                to="/hotels"
                className="text-slate-200 hover:text-white transition-colors font-semibold"
                onClick={() => setIsMenuOpen(false)}
              >
                Hotels
              </Link>
              <Link
                to="/reservations"
                className="text-slate-200 hover:text-white transition-colors font-semibold"
                onClick={() => setIsMenuOpen(false)}
              >
                My Bookings
              </Link>
              <Link
                to="/wishlist"
                className="text-slate-200 hover:text-white transition-colors font-semibold"
                onClick={() => setIsMenuOpen(false)}
              >
                Wishlist
              </Link>
              <Link
                to="/login"
                className="text-slate-200 hover:text-white transition-colors font-semibold"
                onClick={() => setIsMenuOpen(false)}
              >
                Sign In
              </Link>
              <Link
                to="/register"
                className="bg-blue-500 hover:bg-blue-600 px-4 py-2 rounded-lg text-center font-medium shadow-md transform hover:scale-105 transition-all"
                onClick={() => setIsMenuOpen(false)}
              >
                Sign Up
              </Link>
            </div>
          </nav>
        )}
      </div>
    </header>
  );
};

export default Header;
