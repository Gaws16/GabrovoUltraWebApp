import Navigation from "./Navigation";

export default function Header() {
  return (
    <div className="bg-image">
      <Navigation />
      <div className=" ">
        <div className="row d-flex justify-content-center m-5 p-5">
          <div className="col-lg-6 col-md-6 col-sm-12 d-flex flex-column justify-content-center text-center">
            <h1 className="text-white">Welcome to GabrovoUltra</h1>
            <p className="text-white">The best ultra marathon in the world</p>
          </div>
        </div>
      </div>
    </div>
  );
}
