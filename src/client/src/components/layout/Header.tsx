import { Link } from 'react-router-dom';

const Header = () => {

  return (
    <header className="sticky top-0 z-50 bg-slate-700/95 text-white shadow-lg backdrop-blur-sm">
      <div className="container mx-auto px-4 py-4">
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
            <Link to="/reservations" className="text-slate-100 hover:text-white transition-colors font-medium">
              My Bookings
            </Link>
            <Link to="/wishlist" className="text-slate-100 hover:text-white transition-colors font-medium">
              Wishlist
            </Link>
          </nav>

 
          <div className="hidden md:flex items-center gap-3">
            <Link to="/login" className="text-white hover:text-slate-200 font-medium px-4 py-2 rounded-lg hover:bg-slate-600 transition-all">
              Sign In
            </Link>
            <Link to="/register" className="bg-blue-500 text-white px-5 py-2 rounded-lg font-medium hover:bg-blue-600 transition-all shadow-md hover:shadow-lg transform hover:scale-105">
              Sign Up
            </Link>
          </div>


        </div>
      </div>
    </header>
  );
};

export default Header;
